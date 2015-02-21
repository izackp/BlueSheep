









// Generated on 12/11/2014 19:01:37
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class PartyAcceptInvitationMessage : AbstractPartyMessage
    {
        public new const uint ID =5580;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public PartyAcceptInvitationMessage()
        {
        }
        
        public PartyAcceptInvitationMessage(int partyId)
         : base(partyId)
        {
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}