/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class CommandThreadFunctionalities<TShared> : CommandThreadFunctionalities // TypeDefIndex: 11264
	where TShared : SharedFunctionalities
{
	// Fields
	private readonly TShared _shared;

	// Properties
	protected TShared shared { get; }

	// Constructors
	protected CommandThreadFunctionalities() {} // Dummy constructor
	public CommandThreadFunctionalities(CommandThreadContext context, TShared shared) {}
}

