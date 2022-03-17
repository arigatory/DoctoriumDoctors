﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctoriumDoctors.Models
{
    public class MockDoctorRepository : IDoctorRepository
    {
        private readonly ISpecialityRepository _specialityRepository = new MockSpecialtyRepository();
        private readonly Random _random = new Random();
        private DateTime _start = new DateTime(1991, 1, 1);
        private int _range;
        public List<Specialty> Specialties { get; set; }


        public MockDoctorRepository()
        {
            Specialties = _specialityRepository.AllSpecialties.ToList();
            _range = (DateTime.Today - _start).Days;
        }
        public IEnumerable<Doctor> AllDoctors => 
            new List<Doctor> {
                new Doctor{ Id = new Guid("09f748c8-7c23-49ba-88f4-704325d71e41"), FirstName = "Жанна", MiddleName = "Романовна", LastName = "Ковшарева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/1.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("ee09556d-5031-47b5-bb52-02fcbc502270"), FirstName = "Валерия", MiddleName = "Федоровна", LastName = "Шина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/3.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("522eb8d8-bdd1-4ba6-9b3e-49c6945eca3b"), FirstName = "Катерина", MiddleName = "Егоровна", LastName = "Потемнова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/5.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("c704472a-2bfd-47cb-a604-da88c0427b8e"), FirstName = "София", MiddleName = "Василевна", LastName = "Скопцова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/7.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("2990febe-a4ac-418b-9d9c-3840ad8d4b08"), FirstName = "Катерина", MiddleName = "Николаевна", LastName = "Федулеева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/9.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("5870e901-b998-43a6-a984-a7d5b962c22a"), FirstName = "Валерия", MiddleName = "Яковлевна", LastName = "Родягина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/11.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("1ef557a1-9699-4a53-b1c0-7befb94f69a3"), FirstName = "Любовь", MiddleName = "Максимовна", LastName = "Шайдулина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/13.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("6ce7d864-4991-4156-94c1-088cb653dbde"), FirstName = "Тамара", MiddleName = "Петровна", LastName = "Везирова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/15.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("45f30d24-afb6-4195-8637-4727b71a4ed0"), FirstName = "Людмила", MiddleName = "Игоревна", LastName = "Оброукова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/17.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("8eab36ee-d556-4414-aa61-f66fc9bcb74d"), FirstName = "Галина", MiddleName = "Кирилловна", LastName = "Шиндякова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/19.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("805f59dd-5568-4f0d-8afd-ec1530160b50"), FirstName = "Дарья", MiddleName = "Борисовна", LastName = "Литашова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/21.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("182197ed-707e-4687-9c5c-73040d413f54"), FirstName = "Маргарита", MiddleName = "Игоревна", LastName = "Силайчева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/23.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("e8416550-241b-4152-84f5-ee3d992da2cd"), FirstName = "Наталия", MiddleName = "Василевна", LastName = "Арефулова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/25.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("6ebd8214-cd2f-47ca-9b18-84a14ab10cb0"), FirstName = "Маргарита", MiddleName = "Федоровна", LastName = "Легостаева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/27.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("a45c77e4-76fb-4d63-893c-fcc654ac2ca9"), FirstName = "Марина", MiddleName = "Вадимовна", LastName = "Ильчикова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/29.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("c2273435-e9f9-4e5a-9e20-f0206ac93477"), FirstName = "Светлана", MiddleName = "Евгеньевна", LastName = "Лузгинова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/31.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("da7d5364-908a-4035-ab00-65813f7e01f2"), FirstName = "Виолетта", MiddleName = "Дмитриевна", LastName = "Канищева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/33.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("523c4479-074a-46d8-bcf4-ffdfcbe48268"), FirstName = "Алена", MiddleName = "Эдуардовна", LastName = "Кордонская", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/35.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("a26a0fff-505b-433a-8cb6-486556b384c0"), FirstName = "Раиса", MiddleName = "Евгеньевна", LastName = "Филинкова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/37.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("33e734a0-9bfc-4ec1-acd1-f11db2662e55"), FirstName = "Лиза", MiddleName = "Никитична", LastName = "Стобская", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/39.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("4e7d193b-0cc9-44cf-8e01-e268260a8cd4"), FirstName = "Валентина", MiddleName = "Федоровна", LastName = "Чашенкова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/41.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("7d2a7048-1ece-42a1-b36d-14c165e7d121"), FirstName = "Наталья", MiddleName = "Федоровна", LastName = "Самотаева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/43.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("189ee79c-5874-4125-9cb0-a682d071db9d"), FirstName = "Клара", MiddleName = "Николаевна", LastName = "Куконина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/45.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("67945578-e4f7-44ef-af1a-834070eed5bf"), FirstName = "Ева", MiddleName = "Вадимовна", LastName = "Шморкина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/47.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("8274a96e-e780-429a-b2e1-c50bae7dc2fa"), FirstName = "Зинаида", MiddleName = "Михайловна", LastName = "Дураничева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/49.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("0192cdb5-439b-4cbd-8c1d-2559bd05247b"), FirstName = "Катерина", MiddleName = "Егоровна", LastName = "Чемыслова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/51.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("bb45dc4d-20fa-44cf-a67e-ccf5994dd8cd"), FirstName = "Алёна", MiddleName = "Валерьевна", LastName = "Урютова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/53.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("237f6720-b7a6-4e2a-b5b8-f91b0d93bbd3"), FirstName = "Маргарита", MiddleName = "Богдановна", LastName = "Комшина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/55.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("b49ebf2b-5515-4ba3-a456-2d52926a265b"), FirstName = "Надежда", MiddleName = "Егоровна", LastName = "Бикушева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/57.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("42c76984-5d10-4260-b2c4-31e39303c453"), FirstName = "Вероника", MiddleName = "Никитична", LastName = "Карлачева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/59.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("e5269f83-c207-4f7d-8398-2de679fd9a26"), FirstName = "Алиса", MiddleName = "Викторовна", LastName = "Говядинова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/61.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("a69ffd8d-ad97-4447-9381-1ef0c5924297"), FirstName = "Алла", MiddleName = "Аркадьевна", LastName = "Раузинская", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/63.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("578f8c9a-b722-4abf-bfc2-2d858e9a4351"), FirstName = "Лиза", MiddleName = "Эдуардовна", LastName = "Искворина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/65.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("cfc8a398-5a6d-48a5-b1d4-e8ed23dab008"), FirstName = "Ольга", MiddleName = "Кирилловна", LastName = "Тябердина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/67.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("4d4a2ac0-78ea-4f68-8dec-61485449d017"), FirstName = "Екатерина", MiddleName = "Егоровна", LastName = "Марачкова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/69.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("6b74145f-e9ba-4ab0-a378-cc6eabfc1b53"), FirstName = "Тамара", MiddleName = "Василевна", LastName = "Лоренкова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/71.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("9833e293-e1a0-4a12-88bd-35c35eeea54b"), FirstName = "Кира", MiddleName = "Никитична", LastName = "Заволожина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/73.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("74d857f8-2a07-40a5-b02b-e614226caa38"), FirstName = "Алла", MiddleName = "Андреевна", LastName = "Ормилина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/75.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("b32f3a1b-c042-4cdd-a07f-090d778bbbb9"), FirstName = "Людмила", MiddleName = "Борисовна", LastName = "Салкаева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/77.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("676eeea2-ea0d-4aa1-9ebd-bb310b28d196"), FirstName = "Александра", MiddleName = "Борисовна", LastName = "Дандонова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/79.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("5d2fe5c6-f875-46ab-8fd3-81beca3bd818"), FirstName = "Наталия", MiddleName = "Викторовна", LastName = "Лисенская", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/81.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("84ed33f0-7df5-4a9d-9bb5-257e7259dfa3"), FirstName = "Юлия", MiddleName = "Кирилловна", LastName = "Дубальская", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/83.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("64bc35b8-c28f-49cc-891c-913114235e13"), FirstName = "Галина", MiddleName = "Борисовна", LastName = "Басавина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/85.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("af06799e-3d15-4c1b-b8cd-fa80de2a3021"), FirstName = "Алиса", MiddleName = "Никитична", LastName = "Индюкова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/87.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("0253eba4-5463-4e75-814e-10b3bf6c89c4"), FirstName = "Светлана", MiddleName = "Андреевна", LastName = "Лучшева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/89.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("0ed50390-3499-4d42-bc65-c8684cc3c63c"), FirstName = "Дарья", MiddleName = "Викторовна", LastName = "Сивцова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/91.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("5da69c38-2cba-48b0-9bc3-1a6d9de3732f"), FirstName = "Виолетта", MiddleName = "Олеговна", LastName = "Лядова", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/93.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("4b8d7047-af3e-4d10-8e26-1b6231873860"), FirstName = "Ольга", MiddleName = "Кирилловна", LastName = "Залежнева", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/95.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("f5b64071-37df-4efe-a942-acca311d6735"), FirstName = "Кристина", MiddleName = "Борисовна", LastName = "Даудина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/97.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("13b904db-cd86-477b-b449-7dfbdb92127c"), FirstName = "Светлана", MiddleName = "Дмитриевна", LastName = "Шабайкина", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/women/99.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("8c6e63c2-d72a-4a69-9609-ddb311dbffaa"), FirstName = "Валерий", MiddleName = "Алексиевич", LastName = "Журбицкий", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/1.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("5fcde1a0-7692-43cf-a19a-39bc7a2a480c"), FirstName = "Степан", MiddleName = "Данилович", LastName = "Рычалин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/3.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("bc55e29a-4ca7-446d-810a-2dc5c8fd9b86"), FirstName = "Михаил", MiddleName = "Евгеньевич", LastName = "Голомазов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/5.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("293f1e36-aec9-4b3d-90fc-00cb92f9fac6"), FirstName = "Константин", MiddleName = "Данилович", LastName = "Мордашкин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/7.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("e63fa5cb-7958-4ac8-8594-5c658fc66082"), FirstName = "Артём", MiddleName = "Петрович", LastName = "Шарыков", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/9.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("025c724f-8660-487f-a8d0-a13a56520808"), FirstName = "Тарас", MiddleName = "Вадимович", LastName = "Гаевских", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/11.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("0c1cb0e1-4436-4c2b-97c0-5d70f2e70c56"), FirstName = "Леонид", MiddleName = "Василиевич", LastName = "Витовтов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/13.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("a057344f-a784-48cc-83e2-5958b882c371"), FirstName = "Илья", MiddleName = "Антонович", LastName = "Альбегов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/15.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("6e933db5-e9aa-4b6e-9db4-9ea60ac024d6"), FirstName = "Артём", MiddleName = "Фёдорович", LastName = "Салтовский", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/17.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("c5c298f6-bd0c-41e8-922e-cd3f1b2da1be"), FirstName = "Александр", MiddleName = "Виталиевич", LastName = "Храпунов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/19.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("49a9dfc6-ae89-4b60-b86e-3bfcf33f6304"), FirstName = "Леонид", MiddleName = "Яковлевич", LastName = "Висляев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/21.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("69cff1e3-2d8f-477c-beeb-69a97a44e301"), FirstName = "Владимир", MiddleName = "Михаилович", LastName = "Зерин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/23.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("0c01e766-de92-4e26-ac7a-6f4c7fb74c5b"), FirstName = "Евгений", MiddleName = "Леонидович", LastName = "Миродонкин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/25.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("703e1687-e252-4f79-b636-3813df7d6018"), FirstName = "Виталий", MiddleName = "Романович", LastName = "Губакин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/27.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("b119500d-4a53-4e33-becb-6cb6089871dd"), FirstName = "Евгений", MiddleName = "Игоревич", LastName = "Кулюшин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/29.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("2c079742-e0fd-4d6f-9d85-8cdc53cff850"), FirstName = "Игорь", MiddleName = "Максимович", LastName = "Кунельский", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/31.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("172b6269-0574-4805-9bb1-46e87f60be8b"), FirstName = "Альберт", MiddleName = "Георгиевич", LastName = "Копотев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/33.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("cc4bfacc-e44a-430d-be25-03bcad27dbe0"), FirstName = "Денис", MiddleName = "Фёдорович", LastName = "Кундеев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/35.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("d559d1ee-9067-4db7-945c-0042ca86b89d"), FirstName = "Никита", MiddleName = "Игоревич", LastName = "Моржедов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/37.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("8c743d71-3fa3-4923-a585-72ddf24b3763"), FirstName = "Герасим", MiddleName = "Яковлевич", LastName = "Хомков", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/39.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("5add4ef8-bfe6-4dea-a1ea-1e305716d5d2"), FirstName = "Иван", MiddleName = "Юрьевич", LastName = "Басанов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/41.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("ddcb3a9a-466e-468e-a6db-f3d527ac7d4f"), FirstName = "Анатолий", MiddleName = "Андреевич", LastName = "Тимашев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/43.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("4ff0a5d7-280e-492e-967c-16783e0d37e1"), FirstName = "Алексей", MiddleName = "Аркадиевич", LastName = "Зарин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/45.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("4ad83b6e-afc9-4d03-be71-5cd9a3c5b5ef"), FirstName = "Олег", MiddleName = "Валериевич", LastName = "Скозобцев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/47.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("79ca71c2-fc1f-458e-9c78-3716b91dba75"), FirstName = "Станислав", MiddleName = "Андреевич", LastName = "Миринов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/49.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("069812b7-166c-4a6c-8f4e-cf02360acd4f"), FirstName = "Вадим", MiddleName = "Денисович", LastName = "Вахтинский", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/51.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("5c546184-1477-4155-b239-69f510012793"), FirstName = "Вадим", MiddleName = "Борисович", LastName = "Кабашов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/53.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("bc87195a-f73f-4d9c-821a-bff9bb51de81"), FirstName = "Ярослав", MiddleName = "Михаилович", LastName = "Бусаров", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/55.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("b8b83977-bf3c-4363-851e-4f2187a4100f"), FirstName = "Семён", MiddleName = "Викторович", LastName = "Царев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/57.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("2164928e-aa29-4838-a3f9-21f518806830"), FirstName = "Пётр", MiddleName = "Василиевич", LastName = "Добрыднев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/59.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("aaead2a6-59ca-4836-ae18-526fe550d81d"), FirstName = "Артём", MiddleName = "Алексиевич", LastName = "Шершаков", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/61.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("d0f4c1a8-a8d3-48ff-87b8-97e6df9e56b3"), FirstName = "Александр", MiddleName = "Николаевич", LastName = "Выскребцев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/63.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("3b411417-6c57-4825-a375-e065cf435cd0"), FirstName = "Валентин", MiddleName = "Кириллович", LastName = "Полочкин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/65.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("dca9addd-d43d-4b45-a308-bf2781be6a2c"), FirstName = "Вадим", MiddleName = "Василиевич", LastName = "Корхов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/67.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("43aca6f8-b257-45d2-830e-53411dc2b210"), FirstName = "Аркадий", MiddleName = "Яковлевич", LastName = "Лагутин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/69.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("fdd2fc4b-c69d-4fad-bacf-f5f0e2dad901"), FirstName = "Леонид", MiddleName = "Викторович", LastName = "Чехомов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/71.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("e1235973-5e47-4b1e-abeb-359b8dcdbf4c"), FirstName = "Андрей", MiddleName = "Тимофеевич", LastName = "Лесовский", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/73.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("d83586a9-829d-45e0-aaba-33d8e1881717"), FirstName = "Никита", MiddleName = "Алексеевич", LastName = "Шегуров", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/75.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("ae202f93-3282-4552-b050-4773d2d95363"), FirstName = "Герасим", MiddleName = "Викторович", LastName = "Саюшов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/77.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("e15fea20-249e-4fe3-b4f5-ce8fa696e036"), FirstName = "Владимир", MiddleName = "Валериевич", LastName = "Исхаков", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/79.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("b8b2b3b5-e779-4355-8d28-a58f524715bf"), FirstName = "Юрий", MiddleName = "Петрович", LastName = "Колтырин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/81.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("9489ae45-bc34-41b3-bea9-324c4726cfe1"), FirstName = "Валентин", MiddleName = "Евгеньевич", LastName = "Алданов", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/83.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("79070602-f850-4a1e-814d-35d98e7f7343"), FirstName = "Олег", MiddleName = "Романович", LastName = "Крячкин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/85.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("47347c14-1aad-47af-8daf-cbcb34f9c97b"), FirstName = "Вячеслав", MiddleName = "Тимофеевич", LastName = "Гродницкий", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/87.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("acc62d00-0af3-4651-a56b-723dde4d893b"), FirstName = "Валентин", MiddleName = "Антонович", LastName = "Пикуров", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/89.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("938cd8fd-2513-49ec-bf69-044dcbfef5e8"), FirstName = "Яков", MiddleName = "Леонидович", LastName = "Тамохин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/91.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("352ea446-01d9-4283-ba39-5eb60d0c1b0e"), FirstName = "Евгений", MiddleName = "Борисович", LastName = "Антоновцев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/93.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("686369a7-9335-44ad-a2ad-ae6f3cf369ef"), FirstName = "Павел", MiddleName = "Петрович", LastName = "Асейкин", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/95.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("9f081ce9-7409-4276-934a-e9ef1c769257"), FirstName = "Валентин", MiddleName = "Алексиевич", LastName = "Пальцев", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/97.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
                new Doctor{ Id = new Guid("b6ed3f36-3888-4d03-86c4-9136f082454b"), FirstName = "Федор", MiddleName = "Алексиевич", LastName = "Черницкий", Accepted=true, ImageUrl = "https://randomuser.me/api/portraits/men/99.jpg", StartOfWorkExperience = _start.AddDays(_random.Next(_range)), SpecialityId = Specialties.ElementAt(_random.Next(0,Specialties.Count())).Id  },
            };

        public IEnumerable<Doctor> DoctorsOfTheWeek => throw new NotImplementedException();

        public Doctor GetDoctorById(Guid doctorId)
        {
            return AllDoctors.FirstOrDefault(d => d.Id == doctorId);
        }
    }
}