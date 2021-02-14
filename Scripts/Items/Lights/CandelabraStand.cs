using System;
using Server;
using Server.Network;

namespace Server.Items
{
	public class CandelabraStand : BaseLight
	{
		public override int LitItemID{ get { return 0xB26; } }
		public override int UnlitItemID{ get { return 0xA29; } }

		[Constructable]
		public CandelabraStand() : base( 0xA29 )
		{
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle225;
			Weight = 20.0;
		}

		public CandelabraStand( Serial serial ) : base( serial )
		{
		}

        public override void OnSingleClick(Mobile from)
        {
            if (this.Name != null)
            {
                from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", this.Name));
            }
            else
            {
                from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", "a candelabra"));
            }
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}