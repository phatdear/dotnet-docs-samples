/*
 * Copyright 2021 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// [START cloud_game_servers_realm_get]

using Google.Cloud.Gaming.V1;

public class GetRealmSample
{
    public Realm GetRealm(
        string projectId, string regionId, string realmId)
    {
        // Create the client.
        RealmsServiceClient client = RealmsServiceClient.Create();

        GetRealmRequest request = new GetRealmRequest
        {
            RealmName = RealmName.FromProjectLocationRealm(projectId, regionId, realmId)
        };

        // Make the request.
        Realm response = client.GetRealm(request);
        return response;
    }
}
// [END cloud_game_servers_realm_get]