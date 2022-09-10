/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AIMath // TypeDefIndex: 20507
{
    // Fields
    public const float EPSILON = 1E-05f; // Metadata: 0x00AFDB6A
    public const float Infinity = 1F / 0F; // Metadata: 0x00AFDB6E
    public const float NegativeInfinity = -1F / 0F; // Metadata: 0x00AFDB72
    public const float PI = 3.1415927f; // Metadata: 0x00AFDB76
    public const float COS_DEG_80 = 0.173648f; // Metadata: 0x00AFDB7A
    public const float COS_DEG_120 = -0.5f; // Metadata: 0x00AFDB7E
    public const float Deg2Rad = 0.017453292f; // Metadata: 0x00AFDB82
    public const float Rad2Deg = 57.29578f; // Metadata: 0x00AFDB86
    private static System.Random aiRand; // 0x00

    // Nested types
    public struct AICurve // TypeDefIndex: 20508
    {
        // Fields
        public List<AIPoint> data; // 0x00

        // Constructors
        public AICurve(AIPoint[] inputData)
        {
            data = default;
        } // 0x0000000183AAF720-0x0000000183AAF750

        // Methods
        // [XID] // 0x0000000189B0A7C0-0x0000000189B0A7E0
        public bool FindY(float xVal, ref float yVal) => default; // 0x0000000183AAF560-0x0000000183AAF570
                                                                  // [XID] // 0x0000000189794360-0x0000000189794380
        public void SortByX() { } // 0x0000000183AAF3E0-0x0000000183AAF560
    }

    public class EntityDistanceComparer : IComparer<BaseEntityHandle> // TypeDefIndex: 20509
    {
        // Fields
        public Vector3 targetPos; // 0x10

        // Constructors
        public EntityDistanceComparer() { } // 0x0000000183A8EE80-0x0000000183A8EEE0

        // Methods
        // [XID] // 0x0000000189B23A60-0x0000000189B23A80
        public int Compare(BaseEntityHandle t1, BaseEntityHandle t2) => default; // 0x0000000183A8EC80-0x0000000183A8EE80
    }

    // Constructors
    public AIMath() { } // 0x0000000183A9F3F0-0x0000000183A9F450
    static AIMath() { } // 0x0000000183A9F310-0x0000000183A9F3F0

    // Methods
    // [XID] // 0x0000000189984530-0x0000000189984550
    public static float Abs(float f) => default; // 0x0000000183A9C4F0-0x0000000183A9C5B0
                                                 // [XID] // 0x000000018998BFB0-0x000000018998BFD0
    public static float Min(float f1, float f2) => default; // 0x0000000183A9C5B0-0x0000000183A9C670
                                                            // [XID] // 0x0000000189BC7ED0-0x0000000189BC7EF0
    public static float Max(float f1, float f2) => default; // 0x0000000183A9C430-0x0000000183A9C4F0
                                                            // [XID] // 0x000000018999B560-0x000000018999B580
    public static float Square(float f) => default; // 0x0000000183A9EF10-0x0000000183A9EFC0
                                                    // [XID] // 0x00000001899A2CB0-0x00000001899A2CD0
    public static float Pow(float f, float pow) => default; // 0x0000000183A9D3B0-0x0000000183A9D480
                                                            // [XID] // 0x00000001899AA720-0x00000001899AA740
    public static float Log(float f) => default; // 0x0000000183A9BFF0-0x0000000183A9C0B0
                                                 // [XID] // 0x00000001899B20A0-0x00000001899B20C0
    public static bool InRange(float input, float min, float max) => default; // 0x0000000183A9D7A0-0x0000000183A9D880
                                                                              // [XID] // 0x00000001899B94C0-0x00000001899B94E0
    public static bool InTime24hRange(float rangeFrom, float rangeTo, float now) => default; // 0x0000000183A9D2B0-0x0000000183A9D3B0
                                                                                             // [XID] // 0x00000001899C0ED0-0x00000001899C0EF0
    public static float WipeTrivial(float raw) => default; // 0x0000000183A9DD20-0x0000000183A9DE00
                                                           // [IDTag] // 0x00000001899C8470-0x00000001899C84B0
                                                           // [XID] // 0x00000001899C8470-0x00000001899C84B0
    public static bool IsNaN(Vector3 v) => default; // 0x0000000183A9C9E0-0x0000000183A9CAD0
                                                    // [IDTag] // 0x00000001899D2C10-0x00000001899D2C50
                                                    // [XID] // 0x00000001899D2C10-0x00000001899D2C50
    public static bool IsNaN(Quaternion q) => default; // 0x0000000183A9CAD0-0x0000000183A9CBD0
                                                       // [XID] // 0x00000001899DD140-0x00000001899DD160
    public static bool IsInvalidRotation(Quaternion q) => default; // 0x0000000183A9E0E0-0x0000000183A9E290
                                                                   // [XID] // 0x00000001899E4D40-0x00000001899E4D60
    public static bool IsInfinity(Vector3 v) => default; // 0x0000000183A9D880-0x0000000183A9D970
                                                         // [XID] // 0x00000001899EC1D0-0x00000001899EC1F0
    public static bool IsZero(Vector3 v) => default; // 0x0000000183A9BE50-0x0000000183A9BF30
                                                     // [XID] // 0x00000001899F3C30-0x00000001899F3C50
    public static bool IsSame(Vector3 v1, Vector3 v2) => default; // 0x0000000183A9E600-0x0000000183A9E700
                                                                  // [XID] // 0x00000001899FB4B0-0x00000001899FB4D0
    public static bool IsDifferentBy(Vector3 v1, Vector3 v2, float distance) => default; // 0x0000000183A9BBC0-0x0000000183A9BD20
                                                                                         // [XID] // 0x0000000189A02750-0x0000000189A02770
    public static float Distance(Vector3 v1, Vector3 v2)
    {
        return (float)Math.Sqrt(((((v1.y - v2.y) * (v1.y - v2.y))
              + ((v1.x - v2.x) * (v1.x - v2.x)))
             + ((v1.z - v2.z) * (v1.z - v2.z))));
    }// 0x0000000183A9F1D0-0x0000000183A9F310
     // [XID] // 0x0000000189A09EE0-0x0000000189A09F00
    public static float DistanceXZ(Vector3 v1, Vector3 v2) => default; // 0x0000000183A9E4E0-0x0000000183A9E600
                                                                       // [XID] // 0x0000000189A11740-0x0000000189A11760
    public static float DistanceSqr(Vector3 v1, Vector3 v2) => default; // 0x0000000183A9BD20-0x0000000183A9BE50
                                                                        // [XID] // 0x0000000189A18AB0-0x0000000189A18AD0
    public static float DistanceManhattan(Vector3 v1, Vector3 v2)
    {
        return Math.Abs(v1.y - v2.y) + Math.Abs(v1.x - v2.x) + Math.Abs(v1.z - v2.z);
    }// 0x0000000183A9D580-0x0000000183A9D6B0
     // [XID] // 0x0000000189A201B0-0x0000000189A201D0
    public static float DistanceY(Vector3 v1, Vector3 v2) => default; // 0x0000000183A9C270-0x0000000183A9C370
                                                                      // [IDTag] // 0x0000000189A27540-0x0000000189A27580
                                                                      // [XID] // 0x0000000189A27540-0x0000000189A27580
    public static bool InDistanceWithAABBCheck(Vector3 v1, Vector3 v2, float distanceXZ, float distanceY) => default; // 0x0000000183A9E930-0x0000000183A9EB80
                                                                                                                      // [IDTag] // 0x0000000189A31990-0x0000000189A319D0
                                                                                                                      // [XID] // 0x0000000189A31990-0x0000000189A319D0
    public static bool InDistanceWithAABBCheck(Vector3 v1, Vector3 v2, float distance) => default; // 0x0000000183A9E700-0x0000000183A9E930
                                                                                                   // [XID] // 0x0000000189A3C120-0x0000000189A3C140
    public static Vector3 GetNearestGridPointXZ(Vector3 v, float widthX, float widthZ) => default; // 0x0000000183A9C0B0-0x0000000183A9C270
                                                                                                   // [XID] // 0x0000000189A43D70-0x0000000189A43D90
    public static Vector3 Scale(Vector3 v1, Vector3 v2) => default; // 0x0000000183A9EC90-0x0000000183A9EDF0
                                                                    // [XID] // 0x0000000189A4B260-0x0000000189A4B280
    public static float Magnitude(Vector3 v) => default; // 0x0000000183A9D6B0-0x0000000183A9D7A0
                                                         // [XID] // 0x0000000189A528E0-0x0000000189A52900
    public static float MagnitudeXZ(Vector3 v) => default; // 0x0000000183A9E400-0x0000000183A9E4E0
                                                           // [IDTag] // 0x0000000189A5A260-0x0000000189A5A2A0
                                                           // [XID] // 0x0000000189A5A260-0x0000000189A5A2A0
    public static Vector3 Normalize(Vector3 v) => default; // 0x0000000183A9D040-0x0000000183A9D1F0
                                                           // [IDTag] // 0x0000000189A64C80-0x0000000189A64CC0
                                                           // [XID] // 0x0000000189A64C80-0x0000000189A64CC0
    public static Vector3 Normalize(Vector3 v, float magnitude) => default; // 0x0000000183A9CEF0-0x0000000183A9D040
                                                                            // [XID] // 0x0000000189A6F3C0-0x0000000189A6F3E0
    public static Vector2 NormalizeXZ(Vector3 v) => default; // 0x0000000183A9DA30-0x0000000183A9DC60
                                                             // [XID] // 0x0000000189A76C20-0x0000000189A76C40
    public static float Dot(Vector3 v1, Vector3 v2) => default; // 0x0000000183A9EB80-0x0000000183A9EC90
                                                                // [XID] // 0x0000000189682CB0-0x0000000189682CD0
    public static Vector3 XZ(Vector3 v) => default; // 0x0000000183A9EDF0-0x0000000183A9EF10
                                                    // [XID] // 0x0000000189A83E20-0x0000000189A83E40
    public static string ToString(Vector3 v) => default; // 0x0000000183A9C670-0x0000000183A9C9E0
                                                         // [XID] // 0x0000000189A8D770-0x0000000189A8D790
    public static float Sin(float angleRAD) => default; // 0x0000000183A9DC60-0x0000000183A9DD20
                                                        // [XID] // 0x0000000189A94D30-0x0000000189A94D50
    public static float Asin(float sinVal) => default; // 0x0000000183A9D1F0-0x0000000183A9D2B0
                                                       // [XID] // 0x0000000189A9C590-0x0000000189A9C5B0
    public static float Cos(float angleRAD) => default; // 0x0000000183A9E020-0x0000000183A9E0E0
                                                        // [XID] // 0x0000000189AA3D00-0x0000000189AA3D20
    public static float ACos(float cosVal) => default; // 0x0000000183A9D970-0x0000000183A9DA30
                                                       // [XID] // 0x0000000189AAB290-0x0000000189AAB2B0
    public static float Tan(float angleRAD) => default; // 0x0000000183A9C370-0x0000000183A9C430
                                                        // [XID] // 0x0000000189AB2CC0-0x0000000189AB2CE0
    public static float Atan(float tanVal) => default; // 0x0000000183A9BF30-0x0000000183A9BFF0
                                                       // [XID] // 0x0000000189ABA820-0x0000000189ABA840
    public static void SinCos(float angleStep, ref float sinResult, ref float cosResult) { } // 0x0000000183A9D480-0x0000000183A9D580
                                                                                             // [XID] // 0x0000000189AC20F0-0x0000000189AC2110
    public static float GetAngleCos(Vector3 dir1, Vector3 dir2) => default; // 0x0000000183A9CD70-0x0000000183A9CEF0
                                                                            // [XID] // 0x0000000189AC9720-0x0000000189AC9740
    public static float XZAngle(Vector3 v1, Vector3 v2) => default; // 0x0000000183A9E290-0x0000000183A9E400
                                                                    // [XID] // 0x0000000189AD1110-0x0000000189AD1130
    public static float XZSignedAngle(Vector3 v1, Vector3 v2) => default; // 0x0000000183A9CBD0-0x0000000183A9CD70
                                                                          // [IDTag] // 0x0000000189AD8EF0-0x0000000189AD8F30
                                                                          // [XID] // 0x0000000189AD8EF0-0x0000000189AD8F30
    public static float Random(float min, float max) => default; // 0x0000000183A9DE00-0x0000000183A9DF20
                                                                 // [IDTag] // 0x0000000189AE3790-0x0000000189AE37D0
                                                                 // [XID] // 0x0000000189AE3790-0x0000000189AE37D0
    public static int Random(int min, int max) => default; // 0x0000000183A9DF20-0x0000000183A9E020
                                                           // [IDTag] // 0x0000000189AEE240-0x0000000189AEE280
                                                           // [XID] // 0x0000000189AEE240-0x0000000189AEE280
    public static float RandomAsync(float min, float max) => default; // 0x0000000183A9F0C0-0x0000000183A9F1D0
                                                                      // [IDTag] // 0x0000000189AF8AA0-0x0000000189AF8AE0
                                                                      // [XID] // 0x0000000189AF8AA0-0x0000000189AF8AE0
    public static int RandomAsync(int min, int max) => default; // 0x0000000183A9EFC0-0x0000000183A9F0C0
}

