using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace COMP003A.Final
{
    internal class GymMemberEnroll
    {
        // String Fields
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public string Address;
        public string City;
        public string State;
        public string PostalCode;
        public string EmergencyContactName;
        public string EmergencyContactNumber;

        public string Goals;
        public string Memberships;
        public string PaymentMethods;

        public string RiskLevel;
        public string OnboardingTrack;

        // Numeric Fields
        public int Age;
        public int Height;
        public int Weight;
        public int VisitPerWeek;
        public int ExperienceLevel;

        public double Bmi;

        // Boolean Fields
        public bool WantsPersonalTrainer;
        public bool WantsGroupClass;
        public bool ListMedicalConditions;
        public bool WantsHighIntensity;
        public bool HasSignedWaiver;
        public bool WantsTextUpdates;

        //
        public GymMemberEnroll(
            string firstname,
            string lastName,
            string phoneNumber,
            string email,
            string address,
            string city,
            string state,
            string postalCode,
            string emergencyContactName,
            string emergencyContactNumber,
            string goals,
            string memberships,
            string paymentMethod,
            int age,
            int height,
            int weight,
            int visitPerWeek,
            int experienceLevel,
            double bmi,
            bool wantsPersonalTrainer,
            bool wantsGroupClass,
            bool listMedicalConditions,
            bool wantsHighIntensity,
            bool hasSignedWaiver,
            bool wantsTextUpdates,
            string riskLevel,
            string onboardingTrack

         )
        {
            //
            FirstName = firstname;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            City = city;
            State = state;
            PostalCode = postalCode;
            EmergencyContactName = emergencyContactName;
            EmergencyContactNumber = emergencyContactNumber;
            Goals = goals;
            Memberships = memberships;
            PaymentMethods = paymentMethod;

            Age = age;
            Height = height;
            Weight = weight;
            VisitPerWeek = visitPerWeek;
            ExperienceLevel = experienceLevel;
            Bmi = bmi;

            WantsPersonalTrainer = wantsPersonalTrainer;
            WantsGroupClass = wantsGroupClass;
            ListMedicalConditions = listMedicalConditions;
            WantsHighIntensity = wantsHighIntensity;
            HasSignedWaiver = hasSignedWaiver;
            WantsTextUpdates = wantsTextUpdates;

            RiskLevel = riskLevel;
            OnboardingTrack = onboardingTrack; 
        }
    }
}
