﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Azure.Devices.Provisioning.Client
{
    /// <summary>
    /// The ProvisioningRegistrationResult type returned when the X509 Certificate HSM mode is used.
    /// </summary>
    public class ProvisioningRegistrationResultX509Certificate : ProvisioningRegistrationResult
    {
        /// <summary>
        /// The Enrollment Group Id.
        /// </summary>
        public string EnrollmentGroupId { get; private set; }

        public ProvisioningRegistrationResultX509Certificate(
            string registrationId,
            DateTime? createdDateTimeUtc,
            string assignedHub,
            string deviceId,
            ProvisioningRegistrationStatusType status,
            string generationId,
            DateTime? lastUpdatedDateTimeUtc,
            int errorCode,
            string errorMessage,
            string etag,
            string enrollmentGroupId) : base(
                registrationId,
                createdDateTimeUtc,
                assignedHub,
                deviceId,
                status,
                generationId,
                lastUpdatedDateTimeUtc,
                errorCode,
                errorMessage,
                etag)
        {
            EnrollmentGroupId = enrollmentGroupId;
        }
    }
}
