﻿namespace SpaceITgr.Models
{
    public class Quest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DateOfAppointment { get; set; }
        public QuestType QuestType { get; set; }

        public Quest(string Name, string Description, string DateOfAppointment, QuestType QuestType)
        {
            this.Name = Name;
            this.Description = Description;
            this.DateOfAppointment = DateOfAppointment;
            this.QuestType = QuestType;
        }
    }

    public enum QuestType
    {
        Сompleted,
        Current,
        Failed
    } 
}
        