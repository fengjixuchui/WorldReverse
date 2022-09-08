/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public abstract class DecoratorTask : SingeChildTask // TypeDefIndex: 27452
	{
		// Constructors
		protected DecoratorTask() {} // 0x0000000186D8A0A0-0x0000000186D8A100
	
		// Methods
		protected override EBTStatus update_current(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186D8A100-0x0000000186D8A190
		protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186D8A190-0x0000000186D8A2E0
		protected abstract EBTStatus decorate(EBTStatus status);
	}
}
