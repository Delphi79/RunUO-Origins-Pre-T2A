using System; 
using System.Collections.Generic; 
using Server.Items; 

namespace Server.Mobiles 
{ 
	public class SBBaker : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBBaker() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
				Add( new GenericBuyInfo( typeof( BreadLoaf ), 6, 9, 0x103B, 0 ) );
				Add( new GenericBuyInfo( typeof( BreadLoaf ), 5, 9, 0x103C, 0 ) );
				Add( new GenericBuyInfo( typeof( ApplePie ), 7, 9, 0x1041, 0 ) ); //OSI just has Pie, not Apple/Fruit/Meat
				Add( new GenericBuyInfo( typeof( Cake ), 13, 9, 0x9E9, 0 ) );
				Add( new GenericBuyInfo( typeof( Muffins ), 3, 9, 0x9EA, 0 ) );
				Add( new GenericBuyInfo( typeof( SackFlour ), 3, 9, 0x1039, 0 ) );
				Add( new GenericBuyInfo( typeof( FrenchBread ), 5, 9, 0x98C, 0 ) );
             	Add( new GenericBuyInfo( typeof( Cookies ), 3, 9, 0x160b, 0 ) ); 
				Add( new GenericBuyInfo( typeof( CheesePizza ), 8, 9, 0x1040, 0 ) ); // OSI just has Pizza
				Add( new GenericBuyInfo( typeof( JarHoney ), 3, 9, 0x9ec, 0 ) ); 
				//Add (new GenericBuyInfo( typeof( BowlFlour ), 7, 9, 0xA1E, 0 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				Add( typeof( BreadLoaf ), 3 ); 
				Add( typeof( FrenchBread ), 1 ); 
				Add( typeof( Cake ), 5 ); 
				Add( typeof( Cookies ), 3 ); 
				Add( typeof( Muffins ), 2 ); 
				Add( typeof( CheesePizza ), 4 ); 
				Add( typeof( ApplePie ), 5 ); 
				Add( typeof( PeachCobbler ), 5 ); 
				Add( typeof( Quiche ), 6 ); 
				Add( typeof( Dough ), 4 ); 
				Add( typeof( JarHoney ), 1 ); 
				Add( typeof( Pitcher ), 5 );
				Add( typeof( SackFlour ), 1 ); 
				Add( typeof( Eggs ), 1 ); 
			} 
		} 
	} 
}