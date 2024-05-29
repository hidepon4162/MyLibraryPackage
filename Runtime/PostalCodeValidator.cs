using System.Text.RegularExpressions;

namespace MyLibrary
{
    public class PostalCodeValidator
    {
        public static bool IsValidPostalCode(string postalCode)
        {
            // ���{�̗X�֔ԍ��̌`�����`�F�b�N���鐳�K�\��
            string pattern = @"^\d{3}-\d{4}$";

            // ���K�\�����g���ėX�֔ԍ����������`�����ǂ������`�F�b�N
            return Regex.IsMatch(postalCode, pattern);
        }
    }
}