/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using RootMotion;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	// [AddComponentMenu] // 0x00000001895F44D0-0x00000001895F4500
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings> // TypeDefIndex: 9915
	{
		// Fields
		// [Header] // 0x00000001895FD320-0x00000001895FD350
		public PuppetUpdateLimit kinematicCollidersUpdateLimit; // 0x18
		public PuppetUpdateLimit freeUpdateLimit; // 0x20
		public PuppetUpdateLimit fixedUpdateLimit; // 0x28
		public bool collisionStayMessages; // 0x30
		public bool collisionExitMessages; // 0x31
		public float activePuppetCollisionThresholdMlp; // 0x34
		private List<PuppetMaster> _puppets; // 0x48
	
		// Properties
		public int currentlyActivePuppets { /* [XID] */ /* 0x0000000189625900-0x0000000189625940 */ get; /* [XID] */ /* 0x0000000189630230-0x0000000189630270 */ private set; } // 0x0000000187780A40-0x0000000187780AA0 0x0000000187780C00-0x0000000187780C60
		public int currentlyKinematicPuppets { /* [XID] */ /* 0x000000018963AC10-0x000000018963AC50 */ get; /* [XID] */ /* 0x0000000189645200-0x0000000189645240 */ private set; } // 0x0000000187780B00-0x0000000187780B60 0x0000000187780CC0-0x0000000187780D20
		public int currentlyDisabledPuppets { /* [XID] */ /* 0x000000018964F890-0x000000018964F8D0 */ get; /* [XID] */ /* 0x0000000189659FF0-0x000000018965A030 */ private set; } // 0x0000000187780AA0-0x0000000187780B00 0x0000000187780C60-0x0000000187780CC0
		public List<PuppetMaster> puppets { /* [XID] */ /* 0x00000001898A1D80-0x00000001898A1DA0 */ get => default; } // 0x0000000187780B60-0x0000000187780C00 
	
		// Nested types
		[Serializable]
		public class PuppetUpdateLimit // TypeDefIndex: 9916
		{
			// Fields
			// [Range] // 0x00000001896A0E40-0x00000001896A0E60
			public int puppetsPerFrame; // 0x10
			private int index; // 0x14
	
			// Constructors
			public PuppetUpdateLimit() {} // 0x0000000187797350-0x00000001877973C0
	
			// Methods
			// [XID] // 0x000000018986F000-0x000000018986F020
			public void Step(int puppetCount) {} // 0x00000001877970F0-0x00000001877971B0
			// [XID] // 0x00000001896AF680-0x00000001896AF6A0
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster) => default; // 0x00000001877971B0-0x0000000187797350
		}
	
		// Constructors
		public PuppetMasterSettings() {} // 0x0000000187780860-0x0000000187780A40
	
		// Methods
		// [XID] // 0x000000018966BF00-0x000000018966BF20
		public void Register(PuppetMaster puppetMaster) {} // 0x00000001877800E0-0x00000001877801D0
		// [XID] // 0x00000001898E7F40-0x00000001898E7F60
		public void Unregister(PuppetMaster puppetMaster) {} // 0x00000001877801D0-0x00000001877802A0
		// [XID] // 0x000000018967B3E0-0x000000018967B400
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster) => default; // 0x0000000187780440-0x0000000187780510
		// [XID] // 0x00000001898B0E40-0x00000001898B0E60
		public bool UpdateFree(PuppetMaster puppetMaster) => default; // 0x0000000187780370-0x0000000187780440
		// [XID] // 0x000000018968A7E0-0x000000018968A800
		public bool UpdateFixed(PuppetMaster puppetMaster) => default; // 0x00000001877802A0-0x0000000187780370
		// [XID] // 0x00000001897FE560-0x00000001897FE580
		private void Update() {} // 0x0000000187780510-0x0000000187780860
		// [XID] // 0x0000000189BD6800-0x0000000189BD6820
		private void FixedUpdate() {} // 0x0000000187780000-0x00000001877800E0
	}
}
