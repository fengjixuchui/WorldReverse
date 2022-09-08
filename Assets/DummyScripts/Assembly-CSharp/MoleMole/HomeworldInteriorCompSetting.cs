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

namespace MoleMole
{
	[Serializable]
	public class HomeworldInteriorCompSetting // TypeDefIndex: 20385
	{
		// Fields
		public Vector3 facingDir; // 0x10
		public Vector3 wallCenter; // 0x1C
		public List<GameObject> compObjs; // 0x28
		public List<MeshRenderer> compRenders; // 0x30
		public List<GadgetEntity> gadgetOnComps; // 0x38
		public List<Collider> compColliders; // 0x40
		protected bool _compActive; // 0x48
		protected bool _compJustInit; // 0x49
	
		// Constructors
		public HomeworldInteriorCompSetting() {} // Dummy constructor
		public HomeworldInteriorCompSetting(Transform initObjTrans) {} // 0x0000000182BB0050-0x0000000182BB01A0
	
		// Methods
		// [XID] // 0x000000018974DB30-0x000000018974DB50
		public void AddObjTrans(Transform objTrans) {} // 0x0000000182BAF5E0-0x0000000182BAF7E0
		// [XID] // 0x0000000189755160-0x0000000189755180
		public bool HasCollider(Collider collider) => default; // 0x0000000182BAFF70-0x0000000182BB0050
		// [XID] // 0x000000018975C330-0x000000018975C350
		public void SetCompActive(bool active) {} // 0x0000000182BAF350-0x0000000182BAF5E0
		// [XID] // 0x0000000189763D20-0x0000000189763D40
		public void BalanceWallFaceDir(Transform roomCenter) {} // 0x0000000182BAFBA0-0x0000000182BAFF70
		// [XID] // 0x000000018976B4C0-0x000000018976B4E0
		public void UpdateCompParentedGadget(GadgetEntity entity) {} // 0x0000000182BAF7E0-0x0000000182BAF9A0
		// [XID] // 0x0000000189772AC0-0x0000000189772AE0
		public void RemoveGadgetFromParent(GadgetEntity entity) {} // 0x0000000182BAF9A0-0x0000000182BAFBA0
	}
}
