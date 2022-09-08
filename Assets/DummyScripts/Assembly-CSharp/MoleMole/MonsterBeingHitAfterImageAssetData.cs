/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	[CreateAssetMenu] // 0x00000001897406B0-0x0000000189740700
	public sealed class MonsterBeingHitAfterImageAssetData : ScriptableObjectUseFiEdit // TypeDefIndex: 19541
	{
		// Fields
		public uint index; // 0x18
		public float lifeTime; // 0x1C
		public UnityEngine.Material material; // 0x20
		public AnimationCurve positionCurve; // 0x28
		public float XZdistance; // 0x30
		public float Ydistance; // 0x34
		public MonoEffectAfterImage.MaterialProperty[] materialProperty; // 0x38
		private static Dictionary<uint, MonsterBeingHitAfterImageAssetData> _data; // 0x00
		private static uint[] _handles; // 0x08
	
		// Constructors
		public MonsterBeingHitAfterImageAssetData() {} // 0x00000001824AE1E0-0x00000001824AE240
		static MonsterBeingHitAfterImageAssetData() {} // 0x00000001824AE130-0x00000001824AE1E0
	
		// Methods
		// [XID] // 0x0000000189749440-0x0000000189749460
		public static void ReloadFromFile() {} // 0x00000001824ADF30-0x00000001824ADFF0
		[DebuggerHidden] // 0x0000000189750900-0x0000000189750940
		// [XID] // 0x0000000189750900-0x0000000189750940
		public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCAA5 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001824ADFF0-0x00000001824AE130
		// [XID] // 0x000000018975AD00-0x000000018975AD20
		public static void LoadMonsterBeingHitAfterImageAssetData() {} // 0x00000001824AD8E0-0x00000001824ADF30
		// [XID] // 0x0000000189B03CF0-0x0000000189B03D10
		public static MonsterBeingHitAfterImageAssetData GetData(uint index) => default; // 0x00000001824AD700-0x00000001824AD8E0
	}
}
