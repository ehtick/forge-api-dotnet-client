/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *

 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// JsonApiRelationshipsLinksRefsLinks
    /// </summary>
    [DataContract]
    public partial class JsonApiRelationshipsLinksRefsLinks :  IEquatable<JsonApiRelationshipsLinksRefsLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonApiRelationshipsLinksRefsLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JsonApiRelationshipsLinksRefsLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonApiRelationshipsLinksRefsLinks" /> class.
        /// </summary>
        /// <param name="Self">Self (required).</param>
        /// <param name="Related">Related (required).</param>
        public JsonApiRelationshipsLinksRefsLinks(JsonApiLink Self = null, JsonApiLink Related = null)
        {
            // to ensure "Self" is required (not null)
            if (Self == null)
            {
                throw new InvalidDataException("Self is a required property for JsonApiRelationshipsLinksRefsLinks and cannot be null");
            }
            else
            {
                this.Self = Self;
            }
            // to ensure "Related" is required (not null)
            if (Related == null)
            {
                throw new InvalidDataException("Related is a required property for JsonApiRelationshipsLinksRefsLinks and cannot be null");
            }
            else
            {
                this.Related = Related;
            }
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public JsonApiLink Self { get; set; }
        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name="related", EmitDefaultValue=false)]
        public JsonApiLink Related { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonApiRelationshipsLinksRefsLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as JsonApiRelationshipsLinksRefsLinks);
        }

        /// <summary>
        /// Returns true if JsonApiRelationshipsLinksRefsLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonApiRelationshipsLinksRefsLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonApiRelationshipsLinksRefsLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Related == other.Related ||
                    this.Related != null &&
                    this.Related.Equals(other.Related)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.Related != null)
                    hash = hash * 59 + this.Related.GetHashCode();
                return hash;
            }
        }
    }

}

