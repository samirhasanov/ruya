﻿using System;

namespace Ruya.Bus
{
	public class SubscriptionInfo
	{
		private SubscriptionInfo(bool isDynamic, Type handlerType)
		{
			IsDynamic = isDynamic;
			HandlerType = handlerType;
		}

		public bool IsDynamic { get; }
		public Type HandlerType { get; }

		public static SubscriptionInfo Dynamic(Type handlerType) => new SubscriptionInfo(true, handlerType);

		public static SubscriptionInfo Typed(Type handlerType) => new SubscriptionInfo(false, handlerType);
	}
}
