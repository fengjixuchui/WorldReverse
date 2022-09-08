/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Dest.Math
{
	public static class Intersection // TypeDefIndex: 8058
	{
		// Fields
		private static float _intervalThreshold; // 0x00
		private static float _dotThreshold; // 0x04
		private static float _distanceThreshold; // 0x08
	
		// Properties
		public static float IntervalThreshold { /* [XID] */ /* 0x0000000189B871B0-0x0000000189B871D0 */ get; /* [XID] */ /* 0x00000001899D68D0-0x00000001899D68F0 */ set; } // 0x00000001872EED80-0x00000001872EEE50 0x00000001872EF070-0x00000001872EF180
		public static float DotThreshold { /* [XID] */ /* 0x0000000189B95880-0x0000000189B958A0 */ get; /* [XID] */ /* 0x0000000189B9CD60-0x0000000189B9CD80 */ set; } // 0x00000001872EECB0-0x00000001872EED80 0x00000001872EEF60-0x00000001872EF070
		public static float DistanceThreshold { /* [XID] */ /* 0x0000000189AEBD50-0x0000000189AEBD70 */ get; /* [XID] */ /* 0x0000000189A7AE70-0x0000000189A7AE90 */ set; } // 0x00000001872EEBE0-0x00000001872EECB0 0x00000001872EEE50-0x00000001872EEF60
	
		// Constructors
		static Intersection() {} // 0x00000001872EEB70-0x00000001872EEBE0
	
		// Methods
		// [XID] // 0x00000001898EC3B0-0x00000001898EC3D0
		public static bool TestAAB2AAB2(ref AAB2 box0, ref AAB2 box1) => default; // 0x00000001872E0330-0x00000001872E0410
		// [XID] // 0x00000001898F3E80-0x00000001898F3EA0
		public static bool FindAAB2AAB2(ref AAB2 box0, ref AAB2 box1, out AAB2 intersection) {
			intersection = default;
			return default;
		} // 0x00000001872D0CE0-0x00000001872D0E40
		// [XID] // 0x0000000189B4CC90-0x0000000189B4CCB0
		public static bool TestAAB2AAB2OverlapX(ref AAB2 box0, ref AAB2 box1) => default; // 0x00000001872E0190-0x00000001872E0260
		// [XID] // 0x00000001899C7C30-0x00000001899C7C50
		public static bool TestAAB2AAB2OverlapY(ref AAB2 box0, ref AAB2 box1) => default; // 0x00000001872E0260-0x00000001872E0330
		// [XID] // 0x0000000189B5BF50-0x0000000189B5BF70
		public static bool TestAAB2Circle2(ref AAB2 box, ref Circle2 circle) => default; // 0x00000001872E0410-0x00000001872E0520
		// [XID] // 0x0000000189B633F0-0x0000000189B63410
		public static bool TestBox2Box2(ref Box2 box0, ref Box2 box1) => default; // 0x00000001872E09C0-0x00000001872E0E10
		// [XID] // 0x00000001899CF3F0-0x00000001899CF410
		public static bool TestBox2Circle2(ref Box2 box, ref Circle2 circle) => default; // 0x00000001872E0E10-0x00000001872E1020
		// [XID] // 0x0000000189B723E0-0x0000000189B72400
		public static bool TestCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1) => default; // 0x00000001872E2480-0x00000001872E25B0
		// [XID] // 0x0000000189B79920-0x0000000189B79940
		public static bool FindCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1, out Circle2Circle2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D1000-0x00000001872D1420
		// [IDTag] // 0x0000000189B80C30-0x0000000189B80C70
		// [XID] // 0x0000000189B80C30-0x0000000189B80C70
		private static int WhichSide(Polygon2 V, Vector2 P, ref Vector2 D) => default; // 0x00000001872EE970-0x00000001872EEB70
		// [XID] // 0x0000000189B8B0B0-0x0000000189B8B0D0
		public static bool TestConvexPolygon2ConvexPolygon2(Polygon2 convexPolygon0, Polygon2 convexPolygon1) => default; // 0x00000001872E25B0-0x00000001872E28E0
		// [IDTag] // 0x0000000189B92880-0x0000000189B928C0
		// [XID] // 0x0000000189B92880-0x0000000189B928C0
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref AAB2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x00000001872D0800-0x00000001872D0CE0
		// [XID] // 0x00000001899DDF10-0x00000001899DDF30
		public static bool TestLine2AAB2(ref Line2 line, ref AAB2 box) => default; // 0x00000001872E28E0-0x00000001872E2B60
		// [XID] // 0x00000001899E5CE0-0x00000001899E5D00
		public static bool FindLine2AAB2(ref Line2 line, ref AAB2 box, out Line2AAB2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D1420-0x00000001872D1580
		// [XID] // 0x000000018993A900-0x000000018993A920
		private static bool Clip(float denom, float numer, ref float t0, ref float t1) => default; // 0x00000001872CED20-0x00000001872CEE60
		// [IDTag] // 0x0000000189BB3060-0x0000000189BB30A0
		// [XID] // 0x0000000189BB3060-0x0000000189BB30A0
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref Box2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x00000001872CFBD0-0x00000001872D0130
		// [XID] // 0x0000000189BBD600-0x0000000189BBD620
		public static bool TestLine2Box2(ref Line2 line, ref Box2 box) => default; // 0x00000001872E2B60-0x00000001872E2D60
		// [XID] // 0x0000000189BC52C0-0x0000000189BC52E0
		public static bool FindLine2Box2(ref Line2 line, ref Box2 box, out Line2Box2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D1580-0x00000001872D16E0
		// [XID] // 0x00000001896A3380-0x00000001896A33A0
		private static bool Find(ref Vector2 origin, ref Vector2 direction, ref Vector2 center, float radius, out int rootCount, out float t0, out float t1) {
			rootCount = default;
			t0 = default;
			t1 = default;
			return default;
		} // 0x00000001872DE5F0-0x00000001872DE870
		// [XID] // 0x00000001896ECC20-0x00000001896ECC40
		public static bool TestLine2Circle2(ref Line2 line, ref Circle2 circle) => default; // 0x00000001872E2D60-0x00000001872E2F00
		// [XID] // 0x0000000189BDBD60-0x0000000189BDBD80
		public static bool FindLine2Circle2(ref Line2 line, ref Circle2 circle, out Line2Circle2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D16E0-0x00000001872D1980
		// [XID] // 0x00000001895E8610-0x00000001895E8630
		public static bool TestLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon) => default; // 0x00000001872E2F00-0x00000001872E30B0
		// [XID] // 0x0000000189A5FA90-0x0000000189A5FAB0
		public static bool FindLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon, out Line2ConvexPolygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D1980-0x00000001872D1E20
		// [IDTag] // 0x00000001895F77B0-0x00000001895F77F0
		// [XID] // 0x00000001895F77B0-0x00000001895F77F0
		private static IntersectionTypes Classify(ref Line2 line0, ref Line2 line1, out float s0) {
			s0 = default;
			return default;
		} // 0x00000001872CD3C0-0x00000001872CD6B0
		// [IDTag] // 0x0000000189601E50-0x0000000189601E90
		// [XID] // 0x0000000189601E50-0x0000000189601E90
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E30B0-0x00000001872E31C0
		// [IDTag] // 0x0000000189A76230-0x0000000189A76270
		// [XID] // 0x0000000189A76230-0x0000000189A76270
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1) => default; // 0x00000001872E31C0-0x00000001872E32B0
		// [XID] // 0x0000000189616A90-0x0000000189616AB0
		public static bool FindLine2Line2(ref Line2 line0, ref Line2 line1, out Line2Line2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D1E20-0x00000001872D1FE0
		// [IDTag] // 0x000000018961E500-0x000000018961E540
		// [XID] // 0x000000018961E500-0x000000018961E540
		private static IntersectionTypes Classify(ref Line2 line, ref Ray2 ray, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001872CDE00-0x00000001872CE130
		// [IDTag] // 0x0000000189628B20-0x0000000189628B60
		// [XID] // 0x0000000189628B20-0x0000000189628B60
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E32B0-0x00000001872E3430
		// [IDTag] // 0x0000000189633440-0x0000000189633480
		// [XID] // 0x0000000189633440-0x0000000189633480
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray) => default; // 0x00000001872E3430-0x00000001872E3520
		// [XID] // 0x000000018963DD90-0x000000018963DDB0
		public static bool FindLine2Ray2(ref Line2 line, ref Ray2 ray, out Line2Ray2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D1FE0-0x00000001872D2230
		// [IDTag] // 0x00000001896453F0-0x0000000189645430
		// [XID] // 0x00000001896453F0-0x0000000189645430
		private static IntersectionTypes Classify(ref Segment2 segment, ref Line2 line, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001872CCCB0-0x00000001872CCFF0
		// [IDTag] // 0x000000018964F9B0-0x000000018964F9F0
		// [XID] // 0x000000018964F9B0-0x000000018964F9F0
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E3520-0x00000001872E3690
		// [IDTag] // 0x000000018965A0F0-0x000000018965A130
		// [XID] // 0x000000018965A0F0-0x000000018965A130
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment) => default; // 0x00000001872E3690-0x00000001872E3780
		// [XID] // 0x00000001896649F0-0x0000000189664A10
		public static bool FindLine2Segment2(ref Line2 line, ref Segment2 segment, out Line2Segment2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D2230-0x00000001872D2490
		// [XID] // 0x0000000189AB0A90-0x0000000189AB0AB0
		private static void TriangleLineRelations(ref Vector2 origin, ref Vector2 direction, ref Triangle2 triangle, out float dist0, out float dist1, out float dist2, out int sign0, out int sign1, out int sign2, out int positive, out int negative, out int zero) {
			dist0 = default;
			dist1 = default;
			dist2 = default;
			sign0 = default;
			sign1 = default;
			sign2 = default;
			positive = default;
			negative = default;
			zero = default;
		} // 0x00000001872EDF10-0x00000001872EE2E0
		// [XID] // 0x0000000189673E60-0x0000000189673E80
		private static bool GetInterval(ref Vector2 origin, ref Vector2 direction, ref Triangle2 triangle, float dist0, float dist1, float dist2, int sign0, int sign1, int sign2, out float param0, out float param1) {
			param0 = default;
			param1 = default;
			return default;
		} // 0x00000001872DF050-0x00000001872DF3D0
		// [IDTag] // 0x000000018967B600-0x000000018967B640
		// [XID] // 0x000000018967B600-0x000000018967B640
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E3780-0x00000001872E3A60
		// [IDTag] // 0x0000000189685CF0-0x0000000189685D30
		// [XID] // 0x0000000189685CF0-0x0000000189685D30
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle) => default; // 0x00000001872E3A60-0x00000001872E3B50
		// [XID] // 0x0000000189ADE4A0-0x0000000189ADE4C0
		public static bool FindLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out Line2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D2490-0x00000001872D28D0
		// [XID] // 0x0000000189698650-0x0000000189698670
		public static bool TestRay2AAB2(ref Ray2 ray, ref AAB2 box) => default; // 0x00000001872E5F50-0x00000001872E6220
		// [XID] // 0x0000000189B70870-0x0000000189B70890
		public static bool FindRay2AAB2(ref Ray2 ray, ref AAB2 box, out Ray2AAB2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D56E0-0x00000001872D5830
		// [XID] // 0x00000001896A6BB0-0x00000001896A6BD0
		public static bool TestRay2Box2(ref Ray2 ray, ref Box2 box) => default; // 0x00000001872E6220-0x00000001872E6560
		// [XID] // 0x0000000189B955C0-0x0000000189B955E0
		public static bool FindRay2Box2(ref Ray2 ray, ref Box2 box, out Ray2Box2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D5830-0x00000001872D5980
		// [XID] // 0x00000001896B5960-0x00000001896B5980
		public static bool TestRay2Circle2(ref Ray2 ray, ref Circle2 circle) => default; // 0x00000001872E6560-0x00000001872E6700
		// [XID] // 0x00000001896BCC60-0x00000001896BCC80
		public static bool FindRay2Circle2(ref Ray2 ray, ref Circle2 circle, out Ray2Circle2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D5980-0x00000001872D5C50
		// [XID] // 0x0000000189B9CC10-0x0000000189B9CC30
		public static bool TestRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon) => default; // 0x00000001872E6700-0x00000001872E68B0
		// [XID] // 0x00000001896CB620-0x00000001896CB640
		public static bool FindRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon, out Ray2ConvexPolygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D5C50-0x00000001872D60E0
		// [IDTag] // 0x00000001896D2BB0-0x00000001896D2BF0
		// [XID] // 0x00000001896D2BB0-0x00000001896D2BF0
		public static bool TestRay2Polygon2(ref Ray2 ray, Polygon2 polygon) => default; // 0x00000001872E68B0-0x00000001872E6A60
		// [IDTag] // 0x00000001896DD2D0-0x00000001896DD310
		// [XID] // 0x00000001896DD2D0-0x00000001896DD310
		public static bool TestRay2Polygon2(ref Ray2 ray, Segment2[] segments) => default; // 0x00000001872E6A60-0x00000001872E6BA0
		// [IDTag] // 0x00000001896E7830-0x00000001896E7870
		// [XID] // 0x00000001896E7830-0x00000001896E7870
		public static bool FindRay2Polygon2(ref Ray2 ray, Polygon2 polygon, out Ray2Polygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D60E0-0x00000001872D6360
		// [IDTag] // 0x00000001896F1990-0x00000001896F19D0
		// [XID] // 0x00000001896F1990-0x00000001896F19D0
		public static bool FindRay2Polygon2(ref Ray2 ray, Segment2[] segments, out Ray2Polygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D6360-0x00000001872D65A0
		// [IDTag] // 0x00000001896FC6F0-0x00000001896FC730
		// [XID] // 0x00000001896FC6F0-0x00000001896FC730
		private static IntersectionTypes Classify(ref Ray2 ray0, ref Ray2 ray1, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001872CDA70-0x00000001872CDE00
		// [IDTag] // 0x0000000189706B60-0x0000000189706BA0
		// [XID] // 0x0000000189706B60-0x0000000189706BA0
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E6C90-0x00000001872E6F50
		// [IDTag] // 0x0000000189711690-0x00000001897116D0
		// [XID] // 0x0000000189711690-0x00000001897116D0
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1) => default; // 0x00000001872E6BA0-0x00000001872E6C90
		// [XID] // 0x0000000189685AD0-0x0000000189685AF0
		public static bool FindRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Ray2Ray2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D65A0-0x00000001872D6940
		// [IDTag] // 0x0000000189723090-0x00000001897230D0
		// [XID] // 0x0000000189723090-0x00000001897230D0
		private static IntersectionTypes Classify(ref Ray2 ray, ref Segment2 segment, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001872CD6B0-0x00000001872CDA70
		// [IDTag] // 0x000000018972D710-0x000000018972D750
		// [XID] // 0x000000018972D710-0x000000018972D750
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E7040-0x00000001872E72D0
		// [IDTag] // 0x0000000189738100-0x0000000189738140
		// [XID] // 0x0000000189738100-0x0000000189738140
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment) => default; // 0x00000001872E6F50-0x00000001872E7040
		// [XID] // 0x0000000189652700-0x0000000189652720
		public static bool FindRay2Segment2(ref Ray2 ray, ref Segment2 segment, out Ray2Segment2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D6940-0x00000001872D6D40
		// [IDTag] // 0x000000018974A290-0x000000018974A2D0
		// [XID] // 0x000000018974A290-0x000000018974A2D0
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E73C0-0x00000001872E7690
		// [IDTag] // 0x0000000189754930-0x0000000189754970
		// [XID] // 0x0000000189754930-0x0000000189754970
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle) => default; // 0x00000001872E72D0-0x00000001872E73C0
		// [XID] // 0x000000018975EF10-0x000000018975EF30
		public static bool FindRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out Ray2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D6D40-0x00000001872D7180
		// [XID] // 0x0000000189766310-0x0000000189766330
		public static bool TestSegment2AAB2(ref Segment2 segment, ref AAB2 box) => default; // 0x00000001872E94A0-0x00000001872E9780
		// [XID] // 0x000000018976DB60-0x000000018976DB80
		public static bool FindSegment2AAB2(ref Segment2 segment, ref AAB2 box, out Segment2AAB2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D94D0-0x00000001872D9640
		// [XID] // 0x0000000189775090-0x00000001897750B0
		public static bool TestSegment2Box2(ref Segment2 segment, ref Box2 box) => default; // 0x00000001872E9780-0x00000001872E9AE0
		// [XID] // 0x000000018977CA00-0x000000018977CA20
		public static bool FindSegment2Box2(ref Segment2 segment, ref Box2 box, out Segment2Box2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D9640-0x00000001872D97B0
		// [XID] // 0x00000001896ED430-0x00000001896ED450
		public static bool TestSegment2Circle2(ref Segment2 segment, ref Circle2 circle) => default; // 0x00000001872E9AE0-0x00000001872E9D00
		// [XID] // 0x00000001896F4D60-0x00000001896F4D80
		public static bool FindSegment2Circle2(ref Segment2 segment, ref Circle2 circle, out Segment2Circle2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D97B0-0x00000001872D9B20
		// [XID] // 0x0000000189695080-0x00000001896950A0
		public static bool TestSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon) => default; // 0x00000001872E9D00-0x00000001872E9E00
		// [XID] // 0x000000018979A570-0x000000018979A590
		public static bool FindSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon, out Segment2ConvexPolygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D9B20-0x00000001872D9FF0
		// [IDTag] // 0x00000001897A24E0-0x00000001897A2520
		// [XID] // 0x00000001897A24E0-0x00000001897A2520
		private static IntersectionTypes Classify(ref Segment2 segment0, ref Segment2 segment1, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001872CCFF0-0x00000001872CD3C0
		// [IDTag] // 0x00000001897ACD70-0x00000001897ACDB0
		// [XID] // 0x00000001897ACD70-0x00000001897ACDB0
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E9E00-0x00000001872EA0E0
		// [IDTag] // 0x00000001897B7B70-0x00000001897B7BB0
		// [XID] // 0x00000001897B7B70-0x00000001897B7BB0
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1) => default; // 0x00000001872EA0E0-0x00000001872EA1D0
		// [XID] // 0x00000001897C2760-0x00000001897C2780
		public static bool FindSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Segment2Segment2Intr info) {
			info = default;
			return default;
		} // 0x00000001872D9FF0-0x00000001872DA490
		// [IDTag] // 0x00000001897C9E00-0x00000001897C9E40
		// [XID] // 0x00000001897C9E00-0x00000001897C9E40
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872EA1D0-0x00000001872EA4B0
		// [IDTag] // 0x00000001897D4710-0x00000001897D4750
		// [XID] // 0x00000001897D4710-0x00000001897D4750
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle) => default; // 0x00000001872EA4B0-0x00000001872EA5A0
		// [XID] // 0x00000001898019D0-0x00000001898019F0
		public static bool FindSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out Segment2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x00000001872DA490-0x00000001872DA930
		// [IDTag] // 0x00000001897E6900-0x00000001897E6940
		// [XID] // 0x00000001897E6900-0x00000001897E6940
		private static int WhichSide(ref Triangle2 triangle, ref Vector2 P, ref Vector2 D) => default; // 0x00000001872EE6C0-0x00000001872EE970
		// [XID] // 0x00000001897F1500-0x00000001897F1520
		private static void ClipConvexPolygonAgainstLine(ref Vector2 edgeStart, ref Vector2 edgeEnd, ref int quantity, ref Triangle2Triangle2Intr info) {} // 0x00000001872CE130-0x00000001872CED20
		// [XID] // 0x00000001897F8C10-0x00000001897F8C30
		public static bool TestTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1) => default; // 0x00000001872EC6A0-0x00000001872ECA60
		// [XID] // 0x00000001897DBBD0-0x00000001897DBBF0
		public static bool FindTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1, out Triangle2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x00000001872DD4A0-0x00000001872DD6B0
		// [XID] // 0x00000001898079C0-0x00000001898079E0
		public static bool TestAAB3AAB3(ref AAB3 box0, ref AAB3 box1) => default; // 0x00000001872E0790-0x00000001872E0880
		// [XID] // 0x000000018980F090-0x000000018980F0B0
		public static bool FindAAB3AAB3(ref AAB3 box0, ref AAB3 box1, out AAB3 intersection) {
			intersection = default;
			return default;
		} // 0x00000001872D0E40-0x00000001872D1000
		// [XID] // 0x000000018986AA50-0x000000018986AA70
		public static bool TestAAB3AAB3OverlapX(ref AAB3 box0, ref AAB3 box1) => default; // 0x00000001872E0520-0x00000001872E05F0
		// [XID] // 0x000000018981E0E0-0x000000018981E100
		public static bool TestAAB3AAB3OverlapY(ref AAB3 box0, ref AAB3 box1) => default; // 0x00000001872E05F0-0x00000001872E06C0
		// [XID] // 0x000000018983B750-0x000000018983B770
		public static bool TestAAB3AAB3OverlapZ(ref AAB3 box0, ref AAB3 box1) => default; // 0x00000001872E06C0-0x00000001872E0790
		// [XID] // 0x000000018982CDD0-0x000000018982CDF0
		public static bool TestAAB3Sphere3(ref AAB3 box, ref Sphere3 sphere) => default; // 0x00000001872E0880-0x00000001872E09C0
		// [XID] // 0x0000000189834510-0x0000000189834530
		public static bool TestBox3Box3(ref Box3 box0, ref Box3 box1) => default; // 0x00000001872E1020-0x00000001872E20C0
		// [XID] // 0x0000000189943450-0x0000000189943470
		public static bool TestBox3Capsule3(ref Box3 box, ref Capsule3 capsule) => default; // 0x00000001872E20C0-0x00000001872E2190
		// [XID] // 0x00000001898433A0-0x00000001898433C0
		public static bool TestBox3Sphere3(ref Box3 box, ref Sphere3 sphere) => default; // 0x00000001872E2190-0x00000001872E2480
		// [IDTag] // 0x000000018984A570-0x000000018984A5B0
		// [XID] // 0x000000018984A570-0x000000018984A5B0
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref AAB3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x00000001872D0130-0x00000001872D0800
		// [XID] // 0x00000001898546F0-0x0000000189854710
		public static bool TestLine3AAB3(ref Line3 line, ref AAB3 box) => default; // 0x00000001872E3B50-0x00000001872E3E50
		// [XID] // 0x00000001898796B0-0x00000001898796D0
		public static bool FindLine3AAB3(ref Line3 line, ref AAB3 box, out Line3AAB3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D28D0-0x00000001872D2A30
		// [IDTag] // 0x00000001898639D0-0x0000000189863A10
		// [XID] // 0x00000001898639D0-0x0000000189863A10
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref Box3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x00000001872CF370-0x00000001872CFBD0
		// [XID] // 0x000000018986D940-0x000000018986D960
		public static bool TestLine3Box3(ref Line3 line, ref Box3 box) => default; // 0x00000001872E3E50-0x00000001872E42A0
		// [XID] // 0x0000000189874DD0-0x0000000189874DF0
		public static bool FindLine3Box3(ref Line3 line, ref Box3 box, out Line3Box3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D2A30-0x00000001872D2B90
		// [XID] // 0x000000018978AE80-0x000000018978AEA0
		public static bool TestLine3Circle3(ref Line3 line, ref Circle3 circle) => default; // 0x00000001872E42A0-0x00000001872E4390
		// [XID] // 0x0000000189883990-0x00000001898839B0
		public static bool FindLine3Circle3(ref Line3 line, ref Circle3 circle, out Line3Circle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D2B90-0x00000001872D2EF0
		// [IDTag] // 0x000000018988B140-0x000000018988B180
		// [XID] // 0x000000018988B140-0x000000018988B180
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E4480-0x00000001872E46D0
		// [IDTag] // 0x0000000189895460-0x00000001898954A0
		// [XID] // 0x0000000189895460-0x00000001898954A0
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane) => default; // 0x00000001872E4390-0x00000001872E4480
		// [XID] // 0x000000018984D460-0x000000018984D480
		public static bool FindLine3Plane3(ref Line3 line, ref Plane3 plane, out Line3Plane3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D2EF0-0x00000001872D3200
		// [XID] // 0x00000001898A71E0-0x00000001898A7200
		public static bool TestLine3Polygon3(ref Line3 line, Polygon3 polygon) => default; // 0x00000001872E46D0-0x00000001872E47C0
		// [XID] // 0x00000001898AEC30-0x00000001898AEC50
		public static bool FindLine3Polygon3(ref Line3 line, Polygon3 polygon, out Line3Polygon3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D3200-0x00000001872D3500
		// [XID] // 0x00000001898B5F90-0x00000001898B5FB0
		private static bool Point3InsideRectangle3(ref Vector3 point, ref Rectangle3 rectangle) => default; // 0x00000001872DFAD0-0x00000001872DFCD0
		// [XID] // 0x0000000189AD04C0-0x0000000189AD04E0
		public static bool TestLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle) => default; // 0x00000001872E47C0-0x00000001872E48B0
		// [XID] // 0x00000001898C5100-0x00000001898C5120
		public static bool FindLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle, out Line3Rectangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D3500-0x00000001872D3840
		// [XID] // 0x00000001898CC500-0x00000001898CC520
		public static bool TestLine3Sphere3(ref Line3 line, ref Sphere3 sphere) => default; // 0x00000001872E48B0-0x00000001872E4A90
		// [XID] // 0x0000000189AA0180-0x0000000189AA01A0
		public static bool FindLine3Sphere3(ref Line3 line, ref Sphere3 sphere, out Line3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D3840-0x00000001872D3C90
		// [IDTag] // 0x00000001898DB840-0x00000001898DB880
		// [XID] // 0x00000001898DB840-0x00000001898DB880
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E5200-0x00000001872E5660
		// [IDTag] // 0x00000001898E6600-0x00000001898E6640
		// [XID] // 0x00000001898E6600-0x00000001898E6640
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E4A90-0x00000001872E4C10
		// [IDTag] // 0x00000001898F1020-0x00000001898F1060
		// [XID] // 0x00000001898F1020-0x00000001898F1060
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E4F50-0x00000001872E5110
		// [IDTag] // 0x00000001898FB4E0-0x00000001898FB520
		// [XID] // 0x00000001898FB4E0-0x00000001898FB520
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle) => default; // 0x00000001872E5110-0x00000001872E5200
		// [IDTag] // 0x0000000189906010-0x0000000189906050
		// [XID] // 0x0000000189906010-0x0000000189906050
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001872E4DD0-0x00000001872E4F50
		// [IDTag] // 0x00000001899105F0-0x0000000189910630
		// [XID] // 0x00000001899105F0-0x0000000189910630
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001872E4C10-0x00000001872E4DD0
		// [IDTag] // 0x000000018991B4F0-0x000000018991B530
		// [XID] // 0x000000018991B4F0-0x000000018991B530
		public static bool FindLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out Line3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D3C90-0x00000001872D4230
		// [IDTag] // 0x0000000189925B70-0x0000000189925BB0
		// [XID] // 0x0000000189925B70-0x0000000189925BB0
		public static bool FindLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Line3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D43F0-0x00000001872D4570
		// [IDTag] // 0x0000000189930070-0x00000001899300B0
		// [XID] // 0x0000000189930070-0x00000001899300B0
		public static bool FindLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out Line3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D4230-0x00000001872D43F0
		// [XID] // 0x000000018993ABB0-0x000000018993ABD0
		public static bool TestPlane3AAB3(ref Plane3 plane, ref AAB3 box) => default; // 0x00000001872E5660-0x00000001872E57F0
		// [XID] // 0x0000000189941B90-0x0000000189941BB0
		public static bool TestPlane3Box3(ref Plane3 plane, ref Box3 box) => default; // 0x00000001872E57F0-0x00000001872E5A40
		// [XID] // 0x0000000189949770-0x0000000189949790
		public static bool TestPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1) => default; // 0x00000001872E5A40-0x00000001872E5BA0
		// [XID] // 0x0000000189950F30-0x0000000189950F50
		public static bool FindPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1, out Plane3Plane3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D4570-0x00000001872D48F0
		// [XID] // 0x00000001899586E0-0x0000000189958700
		public static bool TestPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere) => default; // 0x00000001872E5BA0-0x00000001872E5CB0
		// [XID] // 0x000000018995FD90-0x000000018995FDB0
		public static bool FindPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere, out Plane3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D48F0-0x00000001872D4C30
		// [XID] // 0x0000000189967680-0x00000001899676A0
		public static bool TestPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle) => default; // 0x00000001872E5CB0-0x00000001872E5F50
		// [XID] // 0x00000001896EEC20-0x00000001896EEC40
		public static bool FindPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle, out Plane3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D4C30-0x00000001872D56E0
		// [XID] // 0x00000001896F6600-0x00000001896F6620
		public static bool TestRay3AAB3(ref Ray3 ray, ref AAB3 box) => default; // 0x00000001872E7690-0x00000001872E7AC0
		// [XID] // 0x000000018997D7B0-0x000000018997D7D0
		public static bool FindRay3AAB3(ref Ray3 ray, ref AAB3 box, out Ray3AAB3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D7180-0x00000001872D72D0
		// [XID] // 0x00000001899853F0-0x0000000189985410
		public static bool TestRay3Box3(ref Ray3 ray, ref Box3 box) => default; // 0x00000001872E7AC0-0x00000001872E80D0
		// [XID] // 0x00000001897FBCE0-0x00000001897FBD00
		public static bool FindRay3Box3(ref Ray3 ray, ref Box3 box, out Ray3Box3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D72D0-0x00000001872D7420
		// [XID] // 0x0000000189994BC0-0x0000000189994BE0
		public static bool TestRay3Circle3(ref Ray3 ray, ref Circle3 circle) => default; // 0x00000001872E80D0-0x00000001872E81C0
		// [XID] // 0x00000001896FDD50-0x00000001896FDD70
		public static bool FindRay3Circle3(ref Ray3 ray, ref Circle3 circle, out Ray3Circle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D7420-0x00000001872D7830
		// [IDTag] // 0x00000001899A3D20-0x00000001899A3D60
		// [XID] // 0x00000001899A3D20-0x00000001899A3D60
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E81C0-0x00000001872E82E0
		// [IDTag] // 0x00000001899AE560-0x00000001899AE5A0
		// [XID] // 0x00000001899AE560-0x00000001899AE5A0
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane) => default; // 0x00000001872E82E0-0x00000001872E83E0
		// [XID] // 0x00000001899B8C50-0x00000001899B8C70
		public static bool FindRay3Plane3(ref Ray3 ray, ref Plane3 plane, out Ray3Plane3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D7830-0x00000001872D7C20
		// [XID] // 0x00000001899C0540-0x00000001899C0560
		public static bool TestRay3Polygon3(ref Ray3 ray, Polygon3 polygon) => default; // 0x00000001872E83E0-0x00000001872E84D0
		// [XID] // 0x00000001899C7D90-0x00000001899C7DB0
		public static bool FindRay3Polygon3(ref Ray3 ray, Polygon3 polygon, out Ray3Polygon3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D7C20-0x00000001872D8000
		// [XID] // 0x00000001896E9C40-0x00000001896E9C60
		public static bool TestRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle) => default; // 0x00000001872E84D0-0x00000001872E85C0
		// [XID] // 0x00000001899D6BB0-0x00000001899D6BD0
		public static bool FindRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle, out Ray3Rectangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D8000-0x00000001872D8400
		// [XID] // 0x00000001899DE090-0x00000001899DE0B0
		public static bool TestRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere) => default; // 0x00000001872E85C0-0x00000001872E87E0
		// [XID] // 0x00000001897DD4B0-0x00000001897DD4D0
		public static bool FindRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere, out Ray3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D8400-0x00000001872D89E0
		// [IDTag] // 0x00000001899ED040-0x00000001899ED080
		// [XID] // 0x00000001899ED040-0x00000001899ED080
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E87E0-0x00000001872E8D30
		// [IDTag] // 0x00000001899F7970-0x00000001899F79B0
		// [XID] // 0x00000001899F7970-0x00000001899F79B0
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E8FA0-0x00000001872E9120
		// [IDTag] // 0x0000000189A01CA0-0x0000000189A01CE0
		// [XID] // 0x0000000189A01CA0-0x0000000189A01CE0
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872E92E0-0x00000001872E94A0
		// [IDTag] // 0x0000000189A0C550-0x0000000189A0C590
		// [XID] // 0x0000000189A0C550-0x0000000189A0C590
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle) => default; // 0x00000001872E8D30-0x00000001872E8E20
		// [IDTag] // 0x0000000189A16980-0x0000000189A169C0
		// [XID] // 0x0000000189A16980-0x0000000189A169C0
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001872E8E20-0x00000001872E8FA0
		// [IDTag] // 0x0000000189A21060-0x0000000189A210A0
		// [XID] // 0x0000000189A21060-0x0000000189A210A0
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001872E9120-0x00000001872E92E0
		// [IDTag] // 0x0000000189A2B310-0x0000000189A2B350
		// [XID] // 0x0000000189A2B310-0x0000000189A2B350
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out Ray3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D8B60-0x00000001872D9130
		// [IDTag] // 0x0000000189A35CA0-0x0000000189A35CE0
		// [XID] // 0x0000000189A35CA0-0x0000000189A35CE0
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Ray3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D89E0-0x00000001872D8B60
		// [IDTag] // 0x0000000189A403C0-0x0000000189A40400
		// [XID] // 0x0000000189A403C0-0x0000000189A40400
		public static bool FindRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out Ray3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872D9130-0x00000001872D92F0
		// [XID] // 0x0000000189A4AA90-0x0000000189A4AAB0
		public static bool TestSegment3AAB3(ref Segment3 segment, ref AAB3 box) => default; // 0x00000001872EA5A0-0x00000001872EA9D0
		// [XID] // 0x0000000189A52020-0x0000000189A52040
		public static bool FindSegment3AAB3(ref Segment3 segment, ref AAB3 box, out Segment3AAB3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DA930-0x00000001872DAAA0
		// [XID] // 0x0000000189A59990-0x0000000189A599B0
		public static bool TestSegment3Box3(ref Segment3 segment, ref Box3 box) => default; // 0x00000001872EA9D0-0x00000001872EAFE0
		// [XID] // 0x000000018978AE40-0x000000018978AE60
		public static bool FindSegment3Box3(ref Segment3 segment, ref Box3 box, out Segment3Box3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DAAA0-0x00000001872DAC10
		// [XID] // 0x0000000189A690C0-0x0000000189A690E0
		public static bool TestSegment3Circle3(ref Segment3 segment, ref Circle3 circle) => default; // 0x00000001872EAFE0-0x00000001872EB0D0
		// [XID] // 0x00000001897ECA30-0x00000001897ECA50
		public static bool FindSegment3Circle3(ref Segment3 segment, ref Circle3 circle, out Segment3Circle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DAC10-0x00000001872DB060
		// [IDTag] // 0x0000000189A77C80-0x0000000189A77CC0
		// [XID] // 0x0000000189A77C80-0x0000000189A77CC0
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872EB0D0-0x00000001872EB340
		// [IDTag] // 0x0000000189A826E0-0x0000000189A82720
		// [XID] // 0x0000000189A826E0-0x0000000189A82720
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane) => default; // 0x00000001872EB340-0x00000001872EB430
		// [XID] // 0x0000000189811D60-0x0000000189811D80
		public static bool FindSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out Segment3Plane3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DB060-0x00000001872DB4B0
		// [XID] // 0x0000000189A943B0-0x0000000189A943D0
		public static bool TestSegment3Polygon3(ref Segment3 segment, Polygon3 polygon) => default; // 0x00000001872EB430-0x00000001872EB520
		// [XID] // 0x00000001898B0090-0x00000001898B00B0
		public static bool FindSegment3Polygon3(ref Segment3 segment, Polygon3 polygon, out Segment3Polygon3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DB4B0-0x00000001872DB8E0
		// [XID] // 0x0000000189B622B0-0x0000000189B622D0
		public static bool TestSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle) => default; // 0x00000001872EB520-0x00000001872EB610
		// [XID] // 0x0000000189AAA800-0x0000000189AAA820
		public static bool FindSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle, out Segment3Rectangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DB8E0-0x00000001872DBD20
		// [XID] // 0x0000000189AB2590-0x0000000189AB25B0
		public static bool TestSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere) => default; // 0x00000001872EB610-0x00000001872EB870
		// [XID] // 0x0000000189AB9B00-0x0000000189AB9B20
		public static bool FindSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere, out Segment3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DBD20-0x00000001872DC380
		// [IDTag] // 0x0000000189AC16C0-0x0000000189AC1700
		// [XID] // 0x0000000189AC16C0-0x0000000189AC1700
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872EBEF0-0x00000001872EC430
		// [IDTag] // 0x0000000189ACBF20-0x0000000189ACBF60
		// [XID] // 0x0000000189ACBF20-0x0000000189ACBF60
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872EB870-0x00000001872EB9F0
		// [IDTag] // 0x0000000189AD6D70-0x0000000189AD6DB0
		// [XID] // 0x0000000189AD6D70-0x0000000189AD6DB0
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872EB9F0-0x00000001872EBBB0
		// [IDTag] // 0x0000000189AE1700-0x0000000189AE1740
		// [XID] // 0x0000000189AE1700-0x0000000189AE1740
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle) => default; // 0x00000001872EC430-0x00000001872EC520
		// [IDTag] // 0x0000000189AEBF50-0x0000000189AEBF90
		// [XID] // 0x0000000189AEBF50-0x0000000189AEBF90
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001872EBD70-0x00000001872EBEF0
		// [IDTag] // 0x0000000189AF6810-0x0000000189AF6850
		// [XID] // 0x0000000189AF6810-0x0000000189AF6850
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001872EBBB0-0x00000001872EBD70
		// [IDTag] // 0x0000000189B00E20-0x0000000189B00E60
		// [XID] // 0x0000000189B00E20-0x0000000189B00E60
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out Segment3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DC380-0x00000001872DC9F0
		// [IDTag] // 0x0000000189B0B540-0x0000000189B0B580
		// [XID] // 0x0000000189B0B540-0x0000000189B0B580
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Segment3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DCBB0-0x00000001872DCD30
		// [IDTag] // 0x0000000189B157F0-0x0000000189B15830
		// [XID] // 0x0000000189B157F0-0x0000000189B15830
		public static bool FindSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out Segment3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DC9F0-0x00000001872DCBB0
		// [XID] // 0x0000000189B20110-0x0000000189B20130
		public static bool TestSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1) => default; // 0x00000001872EC520-0x00000001872EC6A0
		// [XID] // 0x0000000189B27700-0x0000000189B27720
		public static bool FindSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1, out Sphere3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DCD30-0x00000001872DD4A0
		// [XID] // 0x0000000189B2EA50-0x0000000189B2EA70
		private static void ProjectOntoAxis(ref Triangle3 triangle, ref Vector3 axis, out float fmin, out float fmax) {
			fmin = default;
			fmax = default;
		} // 0x00000001872DFCD0-0x00000001872DFEC0
		// [XID] // 0x0000000189B36280-0x0000000189B362A0
		private static void TrianglePlaneRelations(ref Triangle3 triangle, ref Plane3 plane, out float dist0, out float dist1, out float dist2, out int sign0, out int sign1, out int sign2, out int positive, out int negative, out int zero) {
			dist0 = default;
			dist1 = default;
			dist2 = default;
			sign0 = default;
			sign1 = default;
			sign2 = default;
			positive = default;
			negative = default;
			zero = default;
		} // 0x00000001872EE430-0x00000001872EE6C0
		// [XID] // 0x000000018997C020-0x000000018997C040
		private static bool TrianglePlaneRelationsQuick(ref Triangle3 triangle, ref Plane3 plane) => default; // 0x00000001872EE2E0-0x00000001872EE430
		// [XID] // 0x0000000189983C70-0x0000000189983C90
		private static bool IntersectsSegment(ref Plane3 plane, ref Triangle3 triangle, ref Vector3 end0, ref Vector3 end1, bool grazing, out Triangle3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DF3D0-0x00000001872DFAD0
		// [XID] // 0x0000000189B4CC70-0x0000000189B4CC90
		private static int QueryToLine(ref Vector2 test, ref Vector2 vec0, ref Vector2 vec1) => default; // 0x00000001872DFEC0-0x00000001872DFFE0
		// [XID] // 0x0000000189B542C0-0x0000000189B542E0
		private static int QueryToTriangle(ref Vector2 test, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x00000001872DFFE0-0x00000001872E0190
		// [XID] // 0x0000000189B5BF30-0x0000000189B5BF50
		private static bool ContainsPoint(ref Triangle3 triangle, ref Plane3 plane, ref Vector3 point, out Triangle3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872CEE60-0x00000001872CF370
		// [XID] // 0x0000000189B633D0-0x0000000189B633F0
		private static bool GetCoplanarIntersection(ref Plane3 plane, ref Triangle3 tri0, ref Triangle3 tri1, out Triangle3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001872DE870-0x00000001872DF050
		// [IDTag] // 0x0000000189B6AD10-0x0000000189B6AD50
		// [XID] // 0x0000000189B6AD10-0x0000000189B6AD50
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001872ECB50-0x00000001872EDF10
		// [IDTag] // 0x0000000189B75030-0x0000000189B75070
		// [XID] // 0x0000000189B75030-0x0000000189B75070
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1) => default; // 0x00000001872ECA60-0x00000001872ECB50
		// [XID] // 0x0000000189B7F620-0x0000000189B7F640
		public static bool FindTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out Triangle3Triangle3Intr info, bool reportCoplanarIntersections = false /* Metadata: 0x00ADF4BF */) {
			info = default;
			return default;
		} // 0x00000001872DD6B0-0x00000001872DE5F0
		// [XID] // 0x0000000189ACECB0-0x0000000189ACECD0
		public static int FindSegment1Segment1(float seg0Start, float seg0End, float seg1Start, float seg1End, out float w0, out float w1) {
			w0 = default;
			w1 = default;
			return default;
		} // 0x00000001872D92F0-0x00000001872D94D0
	}
}
