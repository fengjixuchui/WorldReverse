/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class ElementManager : MonoBehaviour, IEmoTickable // TypeDefIndex: 8480
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected BaseShapeData _shapeData; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected BaseShapeData _specialShapeData; // 0x20
		private bool _isTickable; // 0x29
		protected BaseEmoAnimation _emoAnim; // 0x30
		protected Dictionary<string, BaseShapeRuntime> _shapeRuntimeCache; // 0x38
		protected EmoStateManager _stateMgr; // 0x40
		protected double _timeCheckPoint; // 0x48
	
		// Properties
		public bool previewMode { get; set; } // 0x00000001873299D0-0x0000000187329A30 0x0000000187329B70-0x0000000187329BD0
		public bool tickable { /* [XID] */ /* 0x000000018992D620-0x000000018992D640 */ get => default; /* [XID] */ /* 0x00000001896A9D70-0x00000001896A9D90 */ set {} } // 0x0000000187329AD0-0x0000000187329B70 0x0000000187329BD0-0x0000000187329C80
		public BaseEmoAnimation emoAnim { /* [XID] */ /* 0x000000018972F1F0-0x000000018972F210 */ get => default; } // 0x0000000187329930-0x00000001873299D0 
		public EmoStateManager stateMgr { /* [XID] */ /* 0x00000001896C72F0-0x00000001896C7310 */ get => default; } // 0x0000000187329A30-0x0000000187329AD0 
	
		// Nested types
		public enum Type // TypeDefIndex: 8481
		{
			NONE = -1,
			CLIP = 0,
			FRAME = 1
		}
	
		[Serializable]
		public class BaseShapeRuntime : ISerializationCallbackReceiver // TypeDefIndex: 8482
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public BaseShapeRuntime() {} // 0x0000000187318740-0x00000001873187A0
	
			// Methods
			// [XID] // 0x0000000189702510-0x0000000189702530
			public void OnBeforeSerialize() {} // 0x00000001873186A0-0x0000000187318740
			// [XID] // 0x0000000189709CB0-0x0000000189709CD0
			public void OnAfterDeserialize() {} // 0x00000001873185D0-0x00000001873186A0
		}
	
		// Constructors
		public ElementManager() {} // 0x0000000187329880-0x0000000187329930
	
		// Methods
		public T GetShapeElement<T>(string name)
			where T : ShapeElement, new() => default;
		// [XID] // 0x00000001896B87B0-0x00000001896B87D0
		protected void AddShapeRuntime(string name, BaseShapeRuntime shapeRuntime) {} // 0x0000000187329120-0x00000001873292E0
		public T GetShapeRuntime<T>(string name)
			where T : BaseShapeRuntime, new() => default;
		// [XID] // 0x000000018974D650-0x000000018974D670
		protected virtual void UpdateShapeRuntime() {} // 0x00000001873297D0-0x0000000187329880
		// [XID] // 0x00000001896CE940-0x00000001896CE960
		public virtual void InitEmoAnim() {} // 0x00000001873292E0-0x0000000187329380
		// [XID] // 0x00000001896D5CC0-0x00000001896D5CE0
		public virtual void InitStateMgr() {} // 0x0000000187329380-0x0000000187329450
		// [XID] // 0x00000001896DD210-0x00000001896DD230
		public virtual void UpdateShapeData() {} // 0x0000000187329730-0x00000001873297D0
		// [XID] // 0x00000001896CD340-0x00000001896CD360
		protected virtual void OnEnable() {} // 0x00000001873295F0-0x0000000187329690
		// [XID] // 0x000000018973E780-0x000000018973E7A0
		protected virtual void OnDisable() {} // 0x0000000187329550-0x00000001873295F0
		// [XID] // 0x0000000189A81570-0x0000000189A81590
		protected virtual void Start() {} // 0x0000000187329690-0x0000000187329730
		// [XID] // 0x00000001896FAD70-0x00000001896FAD90
		protected virtual void LateUpdate() {} // 0x0000000187329450-0x0000000187329550
	}
}
