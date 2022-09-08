/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
    /// <summary>
    /// 昼夜系统
    /// </summary>
    public sealed class LevelTimeManager : InLevelManager // TypeDefIndex: 31521
    {
        // Fields
        public const float SOLAR_THRESHOLD = 0.5f; // Metadata: 0x00B12866
        public const float DAY_TIME_MIN_THRESHOLD = 6f; // Metadata: 0x00B1286A
        public const float DAY_TIME_MAX_THRESHOLD = 19f; // Metadata: 0x00B1286E
        public State curState; // 0x38
                               // [Range] // 0x00000001897C1240-0x00000001897C12A0
                               // [Tooltip] // 0x00000001897C1240-0x00000001897C12A0
        public int Seconds; // 0x40
                            // [Range] // 0x00000001897CD330-0x00000001897CD380
                            // [Tooltip] // 0x00000001897CD330-0x00000001897CD380
        public int Minutes; // 0x44
                            // [Range] // 0x00000001897D7F60-0x00000001897D7FC0
                            // [Tooltip] // 0x00000001897D7F60-0x00000001897D7FC0
        public int Hours; // 0x48
                          // [Tooltip] // 0x00000001897E38F0-0x00000001897E3920
        public int Days; // 0x4C
                         // [Tooltip] // 0x00000001897ECDE0-0x00000001897ECE10
        public int Years; // 0x50
        [Space] // 0x00000001897F5CB0-0x00000001897F5D00
                // [Tooltip] // 0x00000001897F5CB0-0x00000001897F5D00
        public float DayLengthInMinutes; // 0x54
                                         // [Tooltip] // 0x0000000189801DD0-0x0000000189801E00
        private float _hourOfDayLengthInMinutes; // 0x58
                                                 // [Range] // 0x0000000189809220-0x0000000189809270
                                                 // [Tooltip] // 0x0000000189809220-0x0000000189809270
        public int utcOffset; // 0x5C
                              // [Range] // 0x00000001898150A0-0x00000001898150F0
                              // [Tooltip] // 0x00000001898150A0-0x00000001898150F0
        public float Latitude; // 0x60
                               // [Range] // 0x00000001898214D0-0x0000000189821520
                               // [Tooltip] // 0x00000001898214D0-0x0000000189821520
        public float Longitude; // 0x64
        private float internalHour; // 0x68
        private ulong _lastLevelTimeStamp; // 0x70
        private int lastHourUpdate; // 0x78
        private DayType dayType; // 0x7C
        private float _targetInternalHour; // 0x80
        private float _targetRealHour; // 0x84
        private float _targetTickTime; // 0x88
        private Func<float> _computeTickTime; // 0x90
        private Action _targetCallback; // 0x98
        private TimeProgressMode _originalProgressTime; // 0xA0
        private bool _initialized; // 0xA4

        // Properties
        public TimeProgressMode ProgressTime { /* [XID] */ /* 0x00000001898768E0-0x0000000189876920 */ get; /* [XID] */ /* 0x0000000189880FC0-0x0000000189881000 */ private set; } // 0x0000000183A375B0-0x0000000183A37610 0x0000000183A37E70-0x0000000183A37ED0
        public float timeOfDay24 { /* [XID] */ /* 0x0000000189A40420-0x0000000189A40440 */ get => default; } // 0x0000000183A376C0-0x0000000183A37770 
        private bool initialized { /* [XID] */ /* 0x00000001898A12F0-0x00000001898A1310 */ get => default; } // 0x0000000183A37610-0x0000000183A376C0 

        // Events
        public event HourPassed OnHourPassed;
        public event DayPassed OnDayPassed;
        public event YearPassed OnYearPassed;
        public event isNightCB OnNightTime;
        public event isDayCB OnDayTime;

        // Nested types
        public enum State // TypeDefIndex: 31522
        {
            Normal = 0,
            Clock = 1,
            Static = 2
        }

        public enum DayType // TypeDefIndex: 31523
        {
            Invalid = 0,
            Day = 1,
            Night = 2
        }

        public delegate void HourPassed(int e); // TypeDefIndex: 31524; 0x0000000183A27710-0x0000000183A278A0

        public delegate void DayPassed(); // TypeDefIndex: 31525; 0x0000000183A27420-0x0000000183A27580

        public delegate void YearPassed(); // TypeDefIndex: 31526; 0x0000000183A49C90-0x0000000183A49DF0

        public delegate void isNightCB(); // TypeDefIndex: 31527; 0x0000000183A4A6B0-0x0000000183A4A810

        public delegate void isDayCB(); // TypeDefIndex: 31528; 0x0000000183A4A3D0-0x0000000183A4A530

        public enum TimeProgressMode // TypeDefIndex: 31529
        {
            None = 0,
            Simulated = 1,
            SystemTime = 2
        }

        // Constructors
        public LevelTimeManager() { } // 0x0000000183A36F60-0x0000000183A37010

        // Methods
        // [XID] // 0x0000000189892910-0x0000000189892930
        public bool isNight() => default; // 0x0000000183A37820-0x0000000183A378D0
                                          // [XID] // 0x000000018989A050-0x000000018989A070
        public bool isDay() => default; // 0x0000000183A37770-0x0000000183A37820
                                        // [XID] // 0x00000001898A8AE0-0x00000001898A8B00
        public void SetSolarLunarTime(float sol, float lun) { } // 0x0000000183A36560-0x0000000183A36620
                                                                // [XID] // 0x00000001898B0490-0x00000001898B04B0
        public override void Init() { } // 0x0000000183A35750-0x0000000183A35830
                                        // [XID] // 0x00000001898B7AB0-0x00000001898B7AD0
        public override void Destroy() { } // 0x0000000183A35260-0x0000000183A35300
                                           // [XID] // 0x00000001898BF070-0x00000001898BF090
        private void RefreshGameTime() { } // 0x0000000183A35DE0-0x0000000183A360B0
                                           // [XID] // 0x00000001898C6A00-0x00000001898C6A20
        public void SetInternalTimeOfDay(float inHours, bool force = false /* Metadata: 0x00B12865 */) { } // 0x0000000183A361A0-0x0000000183A36560
                                                                                                           // [XID] // 0x00000001898CDFF0-0x00000001898CE010
        public void InitLevelLocalTime() { } // 0x0000000183A35680-0x0000000183A35750
                                             // [XID] // 0x00000001898D5AA0-0x00000001898D5AC0
        public void ChangeState(State state) { } // 0x0000000183A34FE0-0x0000000183A350A0
                                                 // [XID] // 0x00000001898DD6F0-0x00000001898DD710
        public string GetTimeStringWithSeconds() => default; // 0x0000000183A35410-0x0000000183A35560
                                                             // [XID] // 0x00000001898E4F50-0x00000001898E4F70
        public string GetTimeString() => default; // 0x0000000183A35560-0x0000000183A35680
                                                  // [XID] // 0x00000001898EC800-0x00000001898EC820
        public double GetInHours(float hours, float days, float years) => default; // 0x0000000183A35300-0x0000000183A35410
                                                                                   // [XID] // 0x00000001898F4210-0x00000001898F4230
        public void NotifyHourPassed() { } // 0x0000000183A35A40-0x0000000183A35B10
                                           // [XID] // 0x00000001898FB960-0x00000001898FB980
        public void NotifyDayPassed() { } // 0x0000000183A35990-0x0000000183A35A40
                                          // [XID] // 0x0000000189903370-0x0000000189903390
        public void NotifyYearPassed() { } // 0x0000000183A35D30-0x0000000183A35DE0
                                           // [XID] // 0x000000018990A8A0-0x000000018990A8C0
        public void NotifyIsNight() { } // 0x0000000183A35C20-0x0000000183A35D30
                                        // [XID] // 0x00000001899124F0-0x0000000189912510
        public void NotifyIsDay() { } // 0x0000000183A35B10-0x0000000183A35C20
                                      // [XID] // 0x0000000189919DD0-0x0000000189919DF0
        public void ChangeTimeLength(float inMinutes) { } // 0x0000000183A350A0-0x0000000183A35160
                                                          // [XID] // 0x0000000189921640-0x0000000189921660
        public void ResetTimeProgressMode(TimeProgressMode mode) { } // 0x0000000183A360B0-0x0000000183A361A0
                                                                     // [XID] // 0x0000000189928D60-0x0000000189928D80
        public void SetTargetTimeOfDay(float inHours, Action callback) { } // 0x0000000183A36620-0x0000000183A36AC0
                                                                           // [XID] // 0x0000000189930290-0x00000001899302B0
        public void CloseTargetTimeOfDay() { } // 0x0000000183A35160-0x0000000183A35260
                                               // [XID] // 0x0000000189937750-0x0000000189937770
        private float InternalTick() => default; // 0x0000000183A35830-0x0000000183A35990
                                                 // [XID] // 0x000000018993F270-0x000000018993F290
        private float TargetTick() => default; // 0x0000000183A36AC0-0x0000000183A36C30
                                               // [XID] // 0x0000000189946820-0x0000000189946840
        public override void Tick() { } // 0x0000000183A36C30-0x0000000183A36F00
    }
}
