using LMS.Repositories;
using LMS.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services;

public class TeacherService
{
    private readonly TeacherRepository _repository;

    public TeacherService()
    {
        _repository = new TeacherRepository();
    }

    public async Task<IEnumerable<TeacherDto>> GetTeachersForDisplayAsync()
    {
        var teachers = await _repository.GetAllTeachersAsync();

        // Entity ni Dto ga o'girish (Mapping)
        return teachers.Select(t => new TeacherDto
        {
            FullName = $"{t.FirstName} {t.LastName}",
            Subject = t.Subject
        });
    }
}
