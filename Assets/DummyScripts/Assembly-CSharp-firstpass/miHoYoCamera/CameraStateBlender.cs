/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public class CameraStateBlender // TypeDefIndex: 8946
	{
		// Fields
		private Dictionary<int, Dictionary<int, CameraStateBlenderConfig>> _blenderConfigDic; // 0x10
		private ICameraState _preFromCam; // 0x28
		private ICameraState _preBlend; // 0x30
		private ICameraState _camBlend; // 0x38
		private CameraStateData _retData; // 0x40
		private float _blendTime; // 0x118
		private float _duration; // 0x11C
		private CameraStateBlenderConfig.BlendType _blendType; // 0x120
		private EasingFunction.FunctionValue _lerpFunc; // 0x128
		private bool _isFinished; // 0x130
	
		// Properties
		public ICameraState CamA { /* [XID] */ /* 0x00000001896DD190-0x00000001896DD1D0 */ get; /* [XID] */ /* 0x00000001896E7730-0x00000001896E7770 */ set; } // 0x0000000185A74550-0x0000000185A745B0 0x0000000185A74B50-0x0000000185A74BB0
		public ICameraState CamB { /* [XID] */ /* 0x00000001896F18B0-0x00000001896F18F0 */ get; /* [XID] */ /* 0x00000001896FC650-0x00000001896FC690 */ set; } // 0x0000000185A745B0-0x0000000185A74610 0x0000000185A74BB0-0x0000000185A74C10
		private ICameraState PreBlend { /* [XID] */ /* 0x0000000189706AA0-0x0000000189706AC0 */ get => default; } // 0x0000000185A74AB0-0x0000000185A74B50 
		private ICameraState CamBlend { /* [XID] */ /* 0x000000018970E430-0x000000018970E450 */ get => default; } // 0x0000000185A74610-0x0000000185A746B0 
		public CameraStateData Data { /* [XID] */ /* 0x0000000189715870-0x0000000189715890 */ get => default; } // 0x0000000185A746B0-0x0000000185A74910 
		public bool IsValid { /* [XID] */ /* 0x000000018971D390-0x000000018971D3B0 */ get => default; } // 0x0000000185A74910-0x0000000185A74AB0 
		public float BlendRatio { /* [XID] */ /* 0x0000000189BA2D70-0x0000000189BA2D90 */ get => default; } // 0x0000000185A74480-0x0000000185A74550 
	
		// Constructors
		public CameraStateBlender() {} // 0x0000000185A74300-0x0000000185A74480
	
		// Methods
		// [XID] // 0x0000000189BD6D40-0x0000000189BD6D60
		public static CameraStateBlender Create() => default; // 0x0000000185A72DC0-0x0000000185A72E90
		// [XID] // 0x00000001896D5C60-0x00000001896D5C80
		public void RegisterBlenderConfig(Dictionary<int, Dictionary<int, CameraStateBlenderConfig>> blenderConfigDic) {} // 0x0000000185A73310-0x0000000185A733C0
		// [XID] // 0x0000000189BDEAE0-0x0000000189BDEB00
		public void Init() {} // 0x0000000185A73170-0x0000000185A73220
		// [XID] // 0x0000000189733560-0x0000000189733580
		public void Clear() {} // 0x0000000185A72C50-0x0000000185A72DC0
		// [XID] // 0x000000018973AE30-0x000000018973AE50
		public void StartBlend(ICameraState camA, ICameraState camB) {} // 0x0000000185A733C0-0x0000000185A73B40
		// [XID] // 0x0000000189AE8A50-0x0000000189AE8A70
		private bool IsRevert(ICameraState camB) => default; // 0x0000000185A73220-0x0000000185A73310
		// [XID] // 0x000000018974A230-0x000000018974A250
		public void Tick(float deltaTime) {} // 0x0000000185A73B40-0x0000000185A74300
		// [XID] // 0x0000000189751580-0x00000001897515A0
		public void Finish() {} // 0x0000000185A72E90-0x0000000185A72F30
		// [XID] // 0x0000000189758970-0x0000000189758990
		public void Flush() {} // 0x0000000185A72F30-0x0000000185A73170
	}
}
