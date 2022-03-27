// See https://aka.ms/new-console-template for more information
using AutoMapper;
using AutoMapperStudy.Model;
using AutoMapperStudy.Model.Dto;
using AutoMapperStudy.MyProfiles;

Console.WriteLine("Hello, World!");
var configuration=new MapperConfiguration(option => { option.AddProfile<StudentProfile>(); });
var mapper =configuration.CreateMapper();
var stu=new Student{
    Name="nike",
    PassWord="1111"
};
var dto=mapper.Map<StudentDto>(stu);
System.Console.WriteLine(dto.Name);