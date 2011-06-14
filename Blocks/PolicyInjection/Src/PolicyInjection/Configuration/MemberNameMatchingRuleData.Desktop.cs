﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Policy Injection Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System.Collections.Generic;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design.Validation;
using Microsoft.Practices.Unity.InterceptionExtension;
using FakeRules = Microsoft.Practices.EnterpriseLibrary.PolicyInjection.MatchingRules;

namespace Microsoft.Practices.EnterpriseLibrary.PolicyInjection.Configuration
{
    /// <summary>
    /// A configuration element that supports the <see cref="MemberNameMatchingRule"/>.
    /// </summary>
    [ResourceDescription(typeof(DesignResources), "MemberNameMatchingRuleDataDescription")]
    [ResourceDisplayName(typeof(DesignResources), "MemberNameMatchingRuleDataDisplayName")]
    public partial class MemberNameMatchingRuleData
    {
        private const string MatchesPropertyName = "matches";

        /// <summary>
        /// Constructs a new <see cref="MemberNameMatchingRuleData"/> instance.
        /// </summary>
        public MemberNameMatchingRuleData()
        {
            Type = typeof(FakeRules.MemberNameMatchingRule);
        }

        /// <summary>
        /// Constructs a new <see cref="MemberNameMatchingRuleData"/> instance.
        /// </summary>
        /// <param name="matchingRuleName">Matching rule name in configuration file.</param>
        /// <param name="match">Member name pattern to match.</param>
        public MemberNameMatchingRuleData(string matchingRuleName, string match)
            : this(matchingRuleName, new MatchData[] { new MatchData(match) })
        {

        }

        /// <summary>
        /// Constructs a new <see cref="MemberNameMatchingRuleData"/> instance.
        /// </summary>
        /// <param name="matchingRuleName">Matching rule name in configuration file.</param>
        public MemberNameMatchingRuleData(string matchingRuleName)
            : base(matchingRuleName, typeof(FakeRules.MemberNameMatchingRule))
        {
        }

        /// <summary>
        /// Constructs a new <see cref="MemberNameMatchingRuleData"/> instance.
        /// </summary>
        /// <param name="matchingRuleName">Matching rule name in configuration file.</param>
        /// <param name="matches">Collection of <see cref="MatchData"/> containing the patterns
        /// to match. If any pattern matches, the rule matches.</param>
        public MemberNameMatchingRuleData(string matchingRuleName, IEnumerable<MatchData> matches)
            : base(matchingRuleName, typeof(FakeRules.MemberNameMatchingRule))
        {
            foreach (MatchData match in matches)
            {
                Matches.Add(match);
            }
        }

        /// <summary>
        /// The collection of patterns to match.
        /// </summary>
        /// <value>The "matches" child element in config.</value>
        [ConfigurationProperty(MatchesPropertyName)]
        [ConfigurationCollection(typeof(MatchData))]
        [ResourceDescription(typeof(DesignResources), "MemberNameMatchingRuleDataMatchesDescription")]
        [ResourceDisplayName(typeof(DesignResources), "MemberNameMatchingRuleDataMatchesDisplayName")]
        [System.ComponentModel.Editor(CommonDesignTime.EditorTypes.CollectionEditor, CommonDesignTime.EditorTypes.FrameworkElement)]
        [EnvironmentalOverrides(false)]
        [Validation(PolicyInjectionDesignTime.Validators.MatchCollectionPopulatedValidationType)]
        public MatchDataCollection<MatchData> Matches
        {
            get { return (MatchDataCollection<MatchData>)base[MatchesPropertyName]; }
            set { base[MatchesPropertyName] = value; }
        }
    }
}
