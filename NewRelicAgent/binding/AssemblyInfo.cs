using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libNewRelicAgent.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, Frameworks = "CoreTelephony SystemConfiguration", ForceLoad = true)]
