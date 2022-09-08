/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public class ActionConnector<T> // TypeDefIndex: 9611
	{
		// Fields
		public Action<T> dstAction;
		private HashSet<string> connectedActionNames;
	
		// Properties
		public bool isConnected { get => default; }
	
		// Constructors
		public ActionConnector() {}
	
		// Methods
		public void Connect(ref Action<T> srcAction, string name) {}
		public void DisConnect(ref Action<T> srcAction, string name) {}
		private void connecter(T param) {}
	}
}
