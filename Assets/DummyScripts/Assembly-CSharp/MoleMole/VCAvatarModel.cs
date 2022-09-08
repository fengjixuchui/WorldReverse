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
	public class VCAvatarModel : VCHumanoidModel // TypeDefIndex: 11797
	{
		// Fields
		private string _pendantPointName; // 0x1E0
		private MonoEffectProxy _energyEffect; // 0x1E8
		private EntityTimer _emissionTimer; // 0x1F0
		public float leftFootHeelOffset; // 0x1F8
		public float rightFootHeelOffset; // 0x1FC
		public float footLiftUpHeight; // 0x200
		public float ikHipHeightBias; // 0x204
		private static readonly Dictionary<int, float[]> _bodyDataDic; // 0x00
		private AvatarElementStyle.Style _curElementType; // 0x208
		private ElementType _energyType; // 0x210
	
		// Properties
		public override int metaTypeID { /* [XID] */ /* 0x0000000189B70950-0x0000000189B70970 */ get => default; } // 0x0000000183BE4610-0x0000000183BE46B0 
	
		// Constructors
		public VCAvatarModel() {} // 0x0000000183BE4530-0x0000000183BE4610
		static VCAvatarModel() {} // 0x0000000183BE4220-0x0000000183BE4530
	
		// Methods
		// [XID] // 0x000000018968A680-0x000000018968A6A0
		public override void Init() {} // 0x0000000183BE3650-0x0000000183BE3960
		// [XID] // 0x0000000189BD1150-0x0000000189BD1170
		protected override void Tick(float inDeltaTime) {} // 0x0000000183BE4160-0x0000000183BE4220
		// [XID] // 0x0000000189BDFF60-0x0000000189BDFF80
		public override void Destroy() {} // 0x0000000183BE2D70-0x0000000183BE2E70
		// [XID] // 0x00000001896A0C40-0x00000001896A0C60
		protected override void SetupGraphic() {} // 0x0000000183BE3350-0x0000000183BE3400
		// [XID] // 0x000000018963F0B0-0x000000018963F0D0
		private void SetMatToEmotion() {} // 0x0000000183BE3D40-0x0000000183BE3EC0
		// [XID] // 0x00000001896AF560-0x00000001896AF580
		protected void UpdateEmission(float inDeltaTime) {} // 0x0000000183BE3400-0x0000000183BE3650
		// [XID] // 0x00000001896B6C40-0x00000001896B6C60
		public void ChangeEnergyType(ElementType type) {} // 0x0000000183BE2E70-0x0000000183BE3030
		// [XID] // 0x00000001896BDE40-0x00000001896BDE60
		public void ShowChangeEnergy(ElementType type, float changeValue, DataPropOp state) {} // 0x0000000183BE39C0-0x0000000183BE3D40
		// [XID] // 0x00000001896C5750-0x00000001896C5770
		public void ShowFullEnergy(ElementType type, DataPropOp state) {} // 0x0000000183BE30B0-0x0000000183BE3350
		// [XID] // 0x00000001896CCDA0-0x00000001896CCDC0
		public void RemoveEnergyEffects() {} // 0x0000000183BE3EC0-0x0000000183BE3F80
		// [XID] // 0x00000001896D3FC0-0x00000001896D3FE0
		private void ClearEmissionTimer() {} // 0x0000000183BE2C30-0x0000000183BE2D70
		// [XID] // 0x00000001896DB940-0x00000001896DB960
		private void SetEmissionScaler(float scaler, BodyMaterialType bodyType) {} // 0x0000000183BE2AE0-0x0000000183BE2C30
		// [XID] // 0x0000000189866070-0x0000000189866090
		private void SetEmissionColor(Color color, BodyMaterialType bodyType) {} // 0x0000000183BE3FF0-0x0000000183BE4160
	}
}
