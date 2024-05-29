using System.Text.RegularExpressions;

namespace MyLibrary
{
    public class PostalCodeValidator
    {
        public static bool IsValidPostalCode(string postalCode)
        {
            // 日本の郵便番号の形式をチェックする正規表現
            string pattern = @"^\d{3}-\d{4}$";

            // 正規表現を使って郵便番号が正しい形式かどうかをチェック
            return Regex.IsMatch(postalCode, pattern);
        }
    }
}