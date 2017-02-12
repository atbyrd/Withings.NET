﻿using Withings.NET;
using Machine.Specifications;
namespace When
{
    public class GettingRequestToken
	{
		static WithingsClient Subject;


		Because GetRequstTokenHasNotBeenCalled = () => Subject = new WithingsClient();

		It ShouldHaveANullOauthToken = () => Subject.oauthToken.ShouldBeNull();
	}
}
