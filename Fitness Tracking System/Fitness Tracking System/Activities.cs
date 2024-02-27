using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracking_System
{
    public class Activities
    {
        public int ActivityId { get; set; }
        public string ActivityType { get; set; }
        public Dictionary<string, double> Metrics { get; set; }

        public Activities()
        {
            Metrics = new Dictionary<string, double>();
        }

        public static double CalculateCaloriesBurnedWalking(int steps, double distance, int timeTaken)
        {
            double caloriesPerStep = 0.05;
            double caloriesPerKM = 100;
            double caloriesPerMin = 4.25;
            double caloriesBurned = steps * caloriesPerStep + distance * caloriesPerKM + timeTaken * caloriesPerMin;

            return caloriesBurned;
        }

        public static double CalculateCaloriesBurnedSwimming(int laps, double distance, int averageHeartRate)
        {
            double caloriesPerlap = 200;
            double caloriesPerM = 47.15;
            double caloriesPerHeartBeat = 0.03;
            double caloriesBurned = laps * caloriesPerlap + distance * caloriesPerM + averageHeartRate * caloriesPerHeartBeat;

            return caloriesBurned;
        }
        public static double CalculateCaloriesBurnedRunning(int steps, double distance, int averageSpeed)
        {
            double caloriesPerStep = 0.05;
            double caloriesPerKM = 50;
            double caloriesPerSpeed = 0.1;
            double caloriesBurned = steps * caloriesPerStep + distance * caloriesPerKM + averageSpeed * caloriesPerSpeed;

            return caloriesBurned;
        }
        public static double CalculateCaloriesBurnedCycling(int revolutions, double distance, int averageSpeed)
        {
            double caloriesPerRevolution = 0.2;
            double caloriesPerKM = 40;
            double caloriesPerSpeed = 0.15;
            double caloriesBurned = revolutions * caloriesPerRevolution + distance * caloriesPerKM + averageSpeed * caloriesPerSpeed;

            return caloriesBurned;
        }

        public static double CalculateCaloriesBurnedYoga(int minutes, int intensityLevel, int pose)
        {
            double caloriesPerMinute = 3;
            double caloriesPerIntensity = 5;
            double caloriesPerPose = 10;
            double caloriesBurned = minutes * caloriesPerMinute + intensityLevel * caloriesPerIntensity + pose * caloriesPerPose;

            return caloriesBurned;
        }
        public static double CalculateCaloriesBurnedHiking(int steps, double distance, int elevationGain)
        {
            double caloriesPerStep = 0.04;
            double caloriesPerKM = 60;
            double caloriesPerElevationGain = 0.1;
            double caloriesBurned = steps * caloriesPerStep + distance * caloriesPerKM + elevationGain * caloriesPerElevationGain;

            return caloriesBurned;
        }
    }
  }
