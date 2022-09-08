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

namespace Cinemachine
{
	public abstract class CinemachinePathBase : MonoBehaviour // TypeDefIndex: 6837
	{
		// Fields
		// [Range] // 0x0000000189AFF7D0-0x0000000189AFF820
		// [Tooltip] // 0x0000000189AFF7D0-0x0000000189AFF820
		public int m_Resolution; // 0x18
		// [Tooltip] // 0x0000000189B0B5C0-0x0000000189B0B5F0
		public Appearance m_Appearance; // 0x20
		private float[] m_DistanceToPos; // 0x28
		private float[] m_PosToDistance; // 0x30
		private int m_CachedSampleSteps; // 0x38
		private float m_PathLength; // 0x3C
		private float m_cachedPosStepSize; // 0x40
		private float m_cachedDistanceStepSize; // 0x44
	
		// Properties
		public abstract float MinPos { get; }
		public abstract float MaxPos { get; }
		public abstract bool Looped { get; }
		public abstract int DistanceCacheSampleStepsPerSegment { get; }
		public float PathLength { /* [XID] */ /* 0x00000001896D9850-0x00000001896D9870 */ get; } // 0x0000000186CC6CC0-0x0000000186CC6DC0 
	
		// Nested types
		[Serializable]
		// [DocumentationSorting] // 0x0000000189B842E0-0x0000000189B84300
		public class Appearance // TypeDefIndex: 6838
		{
			// Fields
			// [Tooltip] // 0x0000000189B8B0F0-0x0000000189B8B120
			public Color pathColor; // 0x10
			// [Tooltip] // 0x0000000189B94290-0x0000000189B942C0
			public Color inactivePathColor; // 0x20
			// [Range] // 0x0000000189B9CD80-0x0000000189B9CDD0
			// [Tooltip] // 0x0000000189B9CD80-0x0000000189B9CDD0
			public float width; // 0x30
	
			// Constructors
			public Appearance() {} // 0x0000000186CB2090-0x0000000186CB21C0
		}
	
		public enum PositionUnits // TypeDefIndex: 6839
		{
			PathUnits = 0,
			Distance = 1
		}
	
		// Constructors
		protected CinemachinePathBase() {} // 0x0000000186CC6C30-0x0000000186CC6CC0
	
		// Methods
		// [XID] // 0x0000000189B142D0-0x0000000189B142F0
		public virtual float NormalizePos(float pos) => default; // 0x0000000186CC6520-0x0000000186CC66B0
		public abstract Vector3 EvaluatePosition(float pos);
		public abstract Vector3 EvaluateTangent(float pos);
		public abstract Quaternion EvaluateOrientation(float pos);
		// [XID] // 0x0000000189B1BB20-0x0000000189B1BB40
		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment) => default; // 0x0000000186CC57E0-0x0000000186CC5CD0
		// [XID] // 0x0000000189996100-0x0000000189996120
		public float MinUnit(PositionUnits units) => default; // 0x0000000186CC62F0-0x0000000186CC63C0
		// [XID] // 0x00000001898BCF40-0x00000001898BCF60
		public float MaxUnit(PositionUnits units) => default; // 0x0000000186CC6210-0x0000000186CC62F0
		// [XID] // 0x0000000189B31C30-0x0000000189B31C50
		public virtual float NormalizeUnit(float pos, PositionUnits units) => default; // 0x0000000186CC66B0-0x0000000186CC67A0
		// [XID] // 0x0000000189B39070-0x0000000189B39090
		public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units) => default; // 0x0000000186CC55A0-0x0000000186CC56C0
		// [XID] // 0x0000000189B40D60-0x0000000189B40D80
		public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units) => default; // 0x0000000186CC56C0-0x0000000186CC57E0
		// [XID] // 0x0000000189A701A0-0x0000000189A701C0
		public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units) => default; // 0x0000000186CC5480-0x0000000186CC55A0
		// [XID] // 0x0000000189B9D720-0x0000000189B9D740
		public virtual void InvalidateDistanceCache() {} // 0x0000000186CC6160-0x0000000186CC6210
		// [XID] // 0x0000000189B57420-0x0000000189B57440
		public bool DistanceCacheIsValid() => default; // 0x0000000186CC5360-0x0000000186CC5480
		// [XID] // 0x0000000189B664B0-0x0000000189B664D0
		public float NormalizePathDistance(float distance) => default; // 0x0000000186CC63C0-0x0000000186CC6520
		// [XID] // 0x0000000189B6DA90-0x0000000189B6DAB0
		public float GetPathPositionFromDistance(float distance) => default; // 0x0000000186CC5EF0-0x0000000186CC6160
		// [XID] // 0x00000001898CBC90-0x00000001898CBCB0
		public float GetPathDistanceFromPosition(float pos) => default; // 0x0000000186CC5CD0-0x0000000186CC5EF0
		// [XID] // 0x0000000189B7C510-0x0000000189B7C530
		private void ResamplePath(int stepsPerSegment) {} // 0x0000000186CC67A0-0x0000000186CC6C30
	}
}
