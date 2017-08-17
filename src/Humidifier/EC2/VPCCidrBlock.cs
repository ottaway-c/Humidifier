namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using VPCCidrBlockPropertyTypes;

    public class VPCCidrBlock : IResource
    {
        /// <summary>
        /// AmazonProvidedIpv6CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-amazonprovidedipv6cidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? AmazonProvidedIpv6CidrBlock
        {
            get;
            set;
        }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcId
        {
            get;
            set;
        }
    }

    namespace VPCCidrBlockPropertyTypes
    {
    }
}