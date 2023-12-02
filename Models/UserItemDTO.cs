namespace GenesisSkin.Models
{
    public class UserItemDTO
    {
        /// <summary> 用户ID </summary>
        public long Id { get; set; }

        /// <summary> 邮箱 </summary>
        public required string Email { get; set; }

        /// <summary> 昵称 </summary>
        public required string Nickname { get; set; }

        public long Score { get; set; }
    }
}
