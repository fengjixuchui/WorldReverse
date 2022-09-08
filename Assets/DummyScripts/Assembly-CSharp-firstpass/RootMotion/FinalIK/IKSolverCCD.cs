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

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic // TypeDefIndex: 9845
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0xB0
		private Quaternion?[] tempRot; // 0xB8
		private float? _lastAbortCurveValue; // 0xC0
		private float _curveEndTime; // 0xC8
		private float _curveTime; // 0xCC
		private bool _isEnterCurve; // 0xD0
		private Action<IKSolverCCD> _onCurveFinished; // 0xD8
	
		// Constructors
		public IKSolverCCD() {} // 0x00000001868CEEE0-0x00000001868CEF60
	
		// Methods
		// [XID] // 0x0000000189776B00-0x0000000189776B20
		public void FadeOutBoneWeights() {} // 0x00000001868CC890-0x00000001868CCA40
		// [XID] // 0x000000018975B850-0x000000018975B870
		protected override void OnInitiate() {} // 0x00000001868CCB70-0x00000001868CCDA0
		// [XID] // 0x0000000189785980-0x00000001897859A0
		protected override void OnUpdate() {} // 0x00000001868CCDA0-0x00000001868CD350
		// [XID] // 0x00000001897090C0-0x00000001897090E0
		public void ClearTempRot() {} // 0x00000001868CC770-0x00000001868CC890
		// [XID] // 0x00000001898AC080-0x00000001898AC0A0
		public void StarCurve(bool isEnter, Action<IKSolverCCD> callback) {} // 0x00000001868CE930-0x00000001868CEA90
		// [XID] // 0x0000000189990870-0x0000000189990890
		private void UpdateCurrentTimeCurveValue() {} // 0x00000001868CEB50-0x00000001868CECF0
		// [XID] // 0x0000000189B7E520-0x0000000189B7E540
		private float FixWeightByLastRunningCurve(float value) => default; // 0x00000001868CCA40-0x00000001868CCB70
		// [XID] // 0x00000001897AAFE0-0x00000001897AB000
		private void UpdateCurve() {} // 0x00000001868CECF0-0x00000001868CEEE0
		// [XID] // 0x00000001897B2CE0-0x00000001897B2D00
		public void ClearCurveCallBack() {} // 0x00000001868CC6D0-0x00000001868CC770
		// [XID] // 0x00000001899890B0-0x00000001899890D0
		private void Solve(Vector3 targetPosition) {} // 0x00000001868CD350-0x00000001868CE930
	}
}
