using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProvaFinal.Validation;

namespace ProvaFinal.model
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Name { get; set; }
        [DataType(DataType.Date, ErrorMessage="Data em formato inválido")]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        

        public Usuario(string Name, DateTime Birthday) {
            this.Name = Name;
            this.Birthday = Birthday;
            
            
        }
    }
}