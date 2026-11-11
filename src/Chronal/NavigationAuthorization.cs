using System.Runtime.CompilerServices;
using LlvQkpftcKTPAsaRP0ff;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Navigation;

internal static class NavigationAuthorization
{
	[MethodImpl((MethodImplOptions)8)]
	internal static bool CanAccessJava(dN4xMCftS2WHJlRJeqrU? user)
	{
		return user != null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool CanAccessHwidTools(dN4xMCftS2WHJlRJeqrU? user)
	{
		if (user != null)
		{
			if (!user.IsAdmin)
			{
				return user.A9gft8PPVaZ("BETA");
			}
			return true;
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}
