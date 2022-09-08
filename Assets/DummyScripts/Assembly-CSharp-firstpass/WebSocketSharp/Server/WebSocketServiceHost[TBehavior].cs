/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using WebSocketSharp;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Server
{
	internal class WebSocketServiceHost<TBehavior> : WebSocketServiceHost // TypeDefIndex: 10302
		where TBehavior : WebSocketBehavior
	{
		// Fields
		private Func<TBehavior> _creator;
	
		// Properties
		public override System.Type BehaviorType { get => default; }
	
		// Constructors
		public WebSocketServiceHost() {} // Dummy constructor
		internal WebSocketServiceHost(string path, Func<TBehavior> creator, Logger log) {}
		internal WebSocketServiceHost(string path, Func<TBehavior> creator, Action<TBehavior> initializer, Logger log) {}
	
		// Methods
		private Func<TBehavior> createCreator(Func<TBehavior> creator, Action<TBehavior> initializer) => default;
		protected override WebSocketBehavior CreateSession() => default;
	}
}
