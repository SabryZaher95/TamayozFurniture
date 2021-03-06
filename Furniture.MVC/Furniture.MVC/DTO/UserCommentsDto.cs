﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Furniture.MVC.DTO
{
    public class UserCommentsDto
    {
        public string CommentText { get; set; }
        public DateTime? CommentDate { get; set; }
        [EmailAddress(ErrorMessage = "الايميل غير صحيح")]
        [Required(ErrorMessage = "يجب ادخال الايميل")]
        public string UserEmail { get; set; }
        public int? Rating { get; set; }
        [Required(ErrorMessage = "يجب ادخال الاسم")]

        public string UserFullName { get; set; }
        public int? RequestServiceId { get; set; }
    }
}