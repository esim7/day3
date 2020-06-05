using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    // POCO - Plain Old CLR Object
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [MaxLength(10)]
        public string LastName { get; set; }

        [Display(Name = "Оценка")]
        [Range(1, 5, ErrorMessage = "Оценка не является валидной")]
        public double Mark { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}

/*
 *  Добавить поле LastName в Student.cs
 *  Изменить все места кода где используется Student (LastName)
 *  Изменить все представления чтобы принимал/отображал поля LastName
 *  Добавить миграцию и обновить БД
 *  Запустить приложение
 *
 */