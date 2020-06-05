// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

namespace EdFi.Admin.DataAccess.Contexts
{
    public class SqlServerUsersContext : UsersContext
    {
        // The default behavior is appropriate for this sub-class.

#if NETSTANDARD
        public SqlServerUsersContext(string connectionString) : base(connectionString) { }
#endif
    }
}
