/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public class BaseCameraStateRunner<CameraStateType> : ICameraStateRunner // TypeDefIndex: 8959
		where CameraStateType : BaseCameraState
	{
		// Fields
		protected bool _isBackground;
		protected CameraStateType _state;
		protected CameraStateData _retData;
	
		// Properties
		public bool IsBackground { get => default; }
	
		// Constructors
		public BaseCameraStateRunner() {}
	
		// Methods
		public void SwitchRunning(bool background) {}
		public void Init(ICameraState state) {}
		protected virtual void InitInternal() {}
		public void Start() {}
		protected virtual void StartInternal() {}
		public void Collect(float deltaTime) {}
		protected virtual void CollectPreInternal() {}
		protected virtual void CollectInternal(float deltaTime) {}
		public virtual void Tick(float deltaTime) {}
		protected void TickPre() {}
		protected void TickPost() {}
		protected virtual void TickInternal(float deltaTime) {}
		public void Flush(float deltaTime) {}
		protected virtual void FlushInternal(float deltaTime) {}
		public void PostFlushTop() {}
		protected virtual void PostFlushTopInternal() {}
		public virtual void Dispose() {}
	}
}
