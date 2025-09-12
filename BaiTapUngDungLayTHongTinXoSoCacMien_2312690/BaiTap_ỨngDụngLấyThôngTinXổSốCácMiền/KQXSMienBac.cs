using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace BaiTap_ỨngDụngLấyThôngTinXổSốCácMiền
{
    internal class KQXSMienBac
    {
        public DataTable GetKQXSMienBac(string url)
        {
            var web = new HtmlWeb();
            var doc = web.Load(url);

            // Tìm bảng kết quả miền Bắc
            var table = doc.DocumentNode.SelectSingleNode("//table[contains(@class, 'bkqmienbac') or contains(@class, 'kqmienbac')]");
            if (table == null)
                throw new Exception("Không tìm thấy bảng kết quả miền Bắc.");

            var subDoc = new HtmlDocument();
            subDoc.LoadHtml(table.InnerHtml);

            var rows = subDoc.DocumentNode.SelectNodes("//tr");
            if (rows == null || rows.Count == 0)
                throw new Exception("Không có dữ liệu trong bảng.");

            DataTable dt = new DataTable();
            dt.Columns.Add("Giải");
            dt.Columns.Add("Kết quả");

            foreach (var row in rows)
            {
                var tds = row.Elements("td").ToList();
                if (tds.Count < 2) continue;

                string tenGiai = HtmlToPlainText(tds[0].InnerHtml).Trim();
                List<string> ketQua = new List<string>();

                for (int i = 1; i < tds.Count; i++)
                {
                    string raw = tds[i].InnerHtml;

                    // Xử lý cả <br> và <div> để tách các số
                    var soList = Regex.Split(raw, @"<br\s*/?>|</?div.*?>", RegexOptions.IgnoreCase);

                    foreach (var so in soList)
                    {
                        var cleaned = HtmlToPlainText(so).Trim();
                        if (!string.IsNullOrEmpty(cleaned))
                            ketQua.Add(cleaned);
                    }
                }

                string ketQuaGop = string.Join("  ", ketQua); // 2 khoảng trắng cho rõ ràng
                dt.Rows.Add(tenGiai, ketQuaGop);
            }
            // ❌ Xoá dòng đầu (nếu có ít nhất 1 dòng)
            if (dt.Rows.Count > 0)
                dt.Rows.RemoveAt(0);

            // ❌ Xoá dòng cuối (nếu còn dòng sau khi xoá dòng đầu)
            if (dt.Rows.Count > 0)
                dt.Rows.RemoveAt(dt.Rows.Count - 1);

            return dt;
        }

        private static string HtmlToPlainText(string html)
        {
            const string tagWhiteSpace = @"(>|$)(\W|\n|\r)+<";
            const string stripFormatting = @"<[^>]*(>|$)";
            const string lineBreak = @"<(br|BR)\s{0,1}\/{0,1}>";

            var lineBreakRegex = new Regex(lineBreak, RegexOptions.Multiline);
            var stripFormattingRegex = new Regex(stripFormatting, RegexOptions.Multiline);
            var tagWhiteSpaceRegex = new Regex(tagWhiteSpace, RegexOptions.Multiline);

            var text = html;
            text = System.Net.WebUtility.HtmlDecode(text);
            text = tagWhiteSpaceRegex.Replace(text, "><");
            text = lineBreakRegex.Replace(text, Environment.NewLine);
            text = stripFormattingRegex.Replace(text, string.Empty);

            return text;
        }
    }
}
