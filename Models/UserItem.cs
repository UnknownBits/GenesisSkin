using System.ComponentModel.DataAnnotations.Schema;

namespace GenesisSkin.Models
{
    [Table("user")]
    public class UserItem
    {
        /// <summary> 用户ID </summary>
        public long Id { get; set; }

        /// <summary> 邮箱 </summary>
        public required string Email { get; set; }

        /// <summary> 昵称 </summary>
        public required string Nickname { get; set; }

        /// <summary> 密码 </summary>
        public required string PasswordHash { get; set; }

        public long Score { get; set; }

        /// <summary> 盐 </summary>
        public required string Salt { get; set; }
    }
}
