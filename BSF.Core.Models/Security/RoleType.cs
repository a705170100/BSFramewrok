using System.ComponentModel;


namespace BSF.Core.Models.Security
{
    /// <summary>
    /// ��ʾ��ɫ���͵�ö��
    /// </summary>
    [Description("��ɫ����")]
    public enum RoleType
    {
        /// <summary>
        /// �û�����
        /// </summary>
        [Description("�û���ɫ")]
        User = 0,

        /// <summary>
        /// ����Ա����
        /// </summary>
        [Description("�����ɫ")]
        Admin = 1
    }
}
