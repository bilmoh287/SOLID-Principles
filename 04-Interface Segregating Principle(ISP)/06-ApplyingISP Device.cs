using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._04_Interface_Segregating_Principle_ISP_
{

    public interface IMakeCall
    {
        void MakeCall();
    }
    public interface ITakePhoto
    {
        void TakePhoto();
    }
    public interface IRecordVideo
    {
        void RecordVideo();
    }
    public interface ISendEmail
    {
        void SendEmail();
    }
    public interface IUseGPS
    {
        void UseGPS();
    }
    public interface ICamera : ITakePhoto, IRecordVideo
    {
        // This interface is for devices that can take photos and record videos.
    }


    // === Device Interfaces === //
    public interface IPhone : IMakeCall, ICamera, ISendEmail, IUseGPS
    {
        // This interface combines all the functionalities of a phone.
    }
    public interface IComputer : ISendEmail, ICamera
    {
        // This interface is for Computers devices.
    }


    // === Device Implementations === //
    public class SmartPhone : IPhone
    {
        public void MakeCall()
        {
            Console.WriteLine("Making a call.");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking Photo.");
        }

        public void RecordVideo()
        {
            Console.WriteLine("Recording a video.");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending an email.");
        }

        public void UseGPS()
        {
            Console.WriteLine("Using GPS.");
        }
    }

    public class Computer : IComputer
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending an email By Computer.");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking Photo By Computer.");
        }
        public void RecordVideo()
        {
            Console.WriteLine("Recording a video By Computer.");
        }
    }

    public class Program3
    {
        public static void main()
        {
            SmartPhone smartphone = new SmartPhone();
            Console.WriteLine("SmartPhone:");
            smartphone.MakeCall();
            smartphone.TakePhoto();
            smartphone.SendEmail();
            smartphone.UseGPS();

            Computer computer = new Computer();
            Console.WriteLine("\nComputer:");
            computer.SendEmail();
            //computer.TakePhoto();// This will throw an exception.
            //computer.SendEmail();// This will throw an exception.
            //computer.UseGPS();// This will throw an exception.


            Console.ReadKey();


        }
    }
}
