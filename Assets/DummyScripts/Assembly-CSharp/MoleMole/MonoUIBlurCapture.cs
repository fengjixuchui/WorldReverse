/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoUIBlurCapture : MonoBehaviour // TypeDefIndex: 30963
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RawImage _main; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _needBlur; // 0x20
		// [Header] // 0x0000000189803590-0x0000000189803610
		// [Range] // 0x0000000189803590-0x0000000189803610
		// [Tooltip] // 0x0000000189803590-0x0000000189803610
		public float radius; // 0x24
		// [Range] // 0x0000000189813860-0x00000001898138C0
		// [Tooltip] // 0x0000000189813860-0x00000001898138C0
		public int iterations; // 0x28
		private int _iterationCount; // 0x2C
		private int _totalInterationCount; // 0x30
		// [Range] // 0x000000018981FDD0-0x000000018981FE40
		[SerializeField] // 0x000000018981FDD0-0x000000018981FE40
		// [Tooltip] // 0x000000018981FDD0-0x000000018981FE40
		private float _interationPeriod; // 0x34
		private float _interationInterval; // 0x38
		private float _intervalCnt; // 0x3C
		public static bool enableRelease; // 0x00
		private static UnityEngine.Material _blurMat; // 0x08
		protected bool _isStarted; // 0x40
		protected bool _isFinished; // 0x41
		private RenderTexture blur1; // 0x48
		private int iterCnt; // 0x50
	
		// Properties
		public static UnityEngine.Material blurMat { /* [XID] */ /* 0x000000018983D4F0-0x000000018983D510 */ get => default; } // 0x0000000184892E60-0x0000000184892F30 
		public bool isStarted { /* [XID] */ /* 0x0000000189844D30-0x0000000189844D50 */ get => default; /* [XID] */ /* 0x000000018984C140-0x000000018984C160 */ set {} } // 0x0000000184892F30-0x0000000184892FD0 0x0000000184892FD0-0x0000000184893080
	
		// Constructors
		public MonoUIBlurCapture() {} // 0x0000000184892DC0-0x0000000184892E60
		static MonoUIBlurCapture() {} // 0x0000000184892D50-0x0000000184892DC0
	
		// Methods
		// [XID] // 0x000000018982E640-0x000000018982E660
		private void RefreshInteration() {} // 0x0000000184891EB0-0x0000000184891FD0
		// [XID] // 0x0000000189835FE0-0x0000000189836000
		private bool CheckInternel() => default; // 0x0000000184892450-0x0000000184892510
		// [XID] // 0x0000000189853250-0x0000000189853270
		private void OnEnable() {} // 0x0000000184892A10-0x0000000184892B40
		// [XID] // 0x000000018985AD60-0x000000018985AD80
		private void OnDisable() {} // 0x00000001848928F0-0x0000000184892A10
		// [XID] // 0x0000000189862220-0x0000000189862240
		private void Update() {} // 0x0000000184892CB0-0x0000000184892D50
		// [XID] // 0x00000001898696D0-0x00000001898696F0
		public void StartCapture() {} // 0x0000000184892B40-0x0000000184892CB0
		// [XID] // 0x00000001898708D0-0x00000001898708F0
		private void OnGetRenderTexture() {} // 0x0000000184891FD0-0x00000001848922A0
		// [XID] // 0x0000000189878360-0x0000000189878380
		public void EndCapture() {} // 0x00000001848922A0-0x0000000184892450
		// [XID] // 0x000000018987F870-0x000000018987F890
		private void PerformBlur() {} // 0x00000001848927F0-0x00000001848928F0
		// [XID] // 0x0000000189886EC0-0x0000000189886EE0
		public void InterationBlur() {} // 0x0000000184892510-0x00000001848927F0
	}
}
