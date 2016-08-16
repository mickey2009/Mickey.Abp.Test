﻿using Abp.Dependency;
using SimpleTaskSystem.Tasks;
using SimpleTaskSystem.Tasks.Dtos;
using System;

namespace SimpleTaskSystem.ConsoleApp
{
    public class Tester : ITransientDependency
    {
        private readonly ITaskAppService _taskAppService;

        public Tester(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public void Test()
        {
            var result = _taskAppService.GetTasks(new GetTasksInput());

            foreach (var task in result.Tasks)
            {
                Console.WriteLine(task.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("{0} tasks listed.", result.Tasks.Count);
        }


        public void TestException()
        {
            _taskAppService.CreateTask(new CreateTaskInput()
            {
                Description = "xxxxx",
                AssignedPersonId = 5
            });

            Console.WriteLine();
            Console.WriteLine("{0} tasks listed.", "1");
        }
    }
}