using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapsterDemo
{
    /// <summary>
    /// 学生实体
    /// </summary>
    public class StudentEntity : BaseEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int? Sex { get; set; }

        /// <summary>
        /// 学校Id
        /// </summary>
        public int? SchoolId { get; set; }

        //public SchoolEntity SchoolEntity { get; set; }

        public IEnumerable<SchoolEntity> Entities { get; set; }
    }

    public class StudentEntityDTO : BaseEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int? Sex { get; set; }

        /// <summary>
        /// 学校Id
        /// </summary>
        public int? SchoolId { get; set; }

        //public SchoolEntity SchoolEntity { get; set; }

        public IEnumerable<SchoolEntity> Entities { get; set; }
    }

    /// <summary>
    /// 学校
    /// </summary>
    public class SchoolEntity : BaseEntity
    {
        /// <summary>
        /// 学校名称
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 学校代码
        /// </summary>
        public int? Code { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string? Adress { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public SchoolCategoryEnum? Category { get; set; }

        public IEnumerable<StudentEntity> Entities { get; set; }
    }

    public class SchoolEntityDTO : BaseEntity
    {
        /// <summary>
        /// 学校名称
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 学校代码
        /// </summary>
        public int? Code { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string? Adress { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public SchoolCategoryEnum? Category { get; set; }

        public IEnumerable<StudentEntity> Entities { get; set; }
    }
    public class BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public string? CreateUserId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// 修改人Id
        /// </summary>
        public string? UpdateUserId { get; set; }
    }

    /// <summary>
    /// 学校类别
    /// </summary>
    public enum SchoolCategoryEnum
    {
        PrimarySchool = 0,
        HighSchool = 1,
        University = 3,
    }
}
