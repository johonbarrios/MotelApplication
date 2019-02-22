﻿namespace MotelApplication.Common.Models
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = false)]
        public Decimal Price { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Publish On")]
        [DataType(DataType.Date)]
        public DateTime PublishOn { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }


        [JsonIgnore]
        public virtual Category Category { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImagePath))
                {
                    return "noproduct";
                }

                // api en Casa
                return $"http://192.168.1.36:8075/{this.ImagePath.Substring(1)}";


                // api en Trabajo
                //return $"http://192.168.1.100:8075/{this.ImagePath.Substring(1)}";

                //return $"http://192.168.1.100:8001/{this.ImagePath.Substring(1)}";

                //return $"http://valeryjohon-001-site1.etempurl.com/{this.ImagePath.Substring(1)}";
                //return $"https://salesbackend.azurewebsites.net/{this.ImagePath.Substring(1)}";
            }

        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
