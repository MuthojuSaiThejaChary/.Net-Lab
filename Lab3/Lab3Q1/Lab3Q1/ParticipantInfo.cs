using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3Q1Library;
namespace Lab3Q1
{
    class ParticipantInfo
    {
        Participant participants = new Participant();
        public int TotalMarks(Participant participantobj)
        {

            participantobj.ObtainedMarks = participantobj.DotNetMarks + participantobj.WebBasicMarks + participantobj.FoundationMarks;
            participants.ObtainedMarks = participantobj.ObtainedMarks;
            return participantobj.ObtainedMarks;
        }
        public void CalculatePercentage(Participant participantobj)
        {
            Console.WriteLine(participantobj.ObtainedMarks);
            Console.WriteLine(participantobj.TotalMarks);
           int percentage= (participantobj.ObtainedMarks / participantobj.TotalMarks) ;
            participantobj.Percentage = percentage;
            Console.WriteLine(percentage);
        }
        public double GetPercentage(Participant obj)
        {
            return obj.Percentage;
        }
    }
}
