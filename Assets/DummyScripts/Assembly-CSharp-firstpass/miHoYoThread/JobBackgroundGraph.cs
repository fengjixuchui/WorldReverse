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

namespace miHoYoThread
{
	public class JobBackgroundGraph : IGraph // TypeDefIndex: 9010
	{
		// Fields
		private const int DEFAULT_CAPCITY = 10; // Metadata: 0x00AE507D
		private List<INode> _nodes; // 0x10
		private int _jobPriority; // 0x18
		private bool _dirty; // 0x1C
		private bool _isMultiThread; // 0x1D
	
		// Properties
		public int priority { /* [XID] */ /* 0x0000000189A1ADD0-0x0000000189A1ADF0 */ get => default; } // 0x0000000187621920-0x00000001876219C0 
		public int schedulerType { /* [XID] */ /* 0x0000000189BCF870-0x0000000189BCF890 */ get => default; } // 0x00000001876219C0-0x0000000187621A60 
		private bool dirty { /* [XID] */ /* 0x0000000189610DA0-0x0000000189610DC0 */ get => default; } // 0x0000000187621880-0x0000000187621920 
	
		// Constructors
		public JobBackgroundGraph() {} // 0x00000001876217E0-0x0000000187621880
	
		// Methods
		// [XID] // 0x0000000189A4D710-0x0000000189A4D730
		public void SetPriority(int priority) {} // 0x0000000187621230-0x00000001876212E0
		// [XID] // 0x0000000189BD4010-0x0000000189BD4030
		public void SetSchedulerType(int stype) {} // 0x00000001876212E0-0x0000000187621390
		// [XID] // 0x0000000189BDB930-0x0000000189BDB950
		public void SwitchRunnerPool(IRunnerPool runnerPool) {} // 0x0000000187621730-0x00000001876217E0
		// [XID] // 0x00000001895EB750-0x00000001895EB770
		public void SwitchMultiThread(bool isMultiThread) {} // 0x0000000187621680-0x0000000187621730
		// [XID] // 0x00000001895F2B50-0x00000001895F2B70
		public void Collect() {} // 0x0000000187620770-0x0000000187620810
		// [XID] // 0x0000000189BD6CE0-0x0000000189BD6D00
		public void Start() {} // 0x0000000187621430-0x0000000187621680
		// [XID] // 0x0000000189601DB0-0x0000000189601DD0
		public void StartMainThreadTask() {} // 0x0000000187621390-0x0000000187621430
		// [XID] // 0x00000001896095C0-0x00000001896095E0
		public void Flush() {} // 0x00000001876209D0-0x0000000187620A70
		// [XID] // 0x0000000189618290-0x00000001896182B0
		public void SetDirty() {} // 0x0000000187621190-0x0000000187621230
		// [XID] // 0x000000018961FD50-0x000000018961FD70
		public void AddNode(INode node) {} // 0x0000000187620670-0x0000000187620770
		// [XID] // 0x0000000189627070-0x0000000189627090
		public void RemoveNode(INode node) {} // 0x0000000187620FF0-0x0000000187621190
		// [XID] // 0x000000018962E970-0x000000018962E990
		public void AddGroup(IGroup group) {} // 0x00000001876205C0-0x0000000187620670
		// [XID] // 0x00000001896366A0-0x00000001896366C0
		public void RemoveGroup(IGroup group) {} // 0x0000000187620F40-0x0000000187620FF0
		// [XID] // 0x000000018963DCD0-0x000000018963DCF0
		public bool IsFinished() => default; // 0x0000000187620A70-0x0000000187620BC0
		// [XID] // 0x0000000189645350-0x0000000189645370
		public void OnPause() {} // 0x0000000187620BC0-0x0000000187620D80
		// [XID] // 0x0000000189A671B0-0x0000000189A671D0
		public void OnResume() {} // 0x0000000187620D80-0x0000000187620F40
		// [XID] // 0x0000000189654170-0x0000000189654190
		public void Destroy() {} // 0x0000000187620810-0x00000001876209D0
	}
}
