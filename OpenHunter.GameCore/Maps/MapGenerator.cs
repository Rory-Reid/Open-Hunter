namespace OpenHunter.GameCore.Maps
{
	public class MapGenerator : IMapGenerator
	{
		public IMap CreateNewMap()
		{
			return this.GenerateProofOfConceptMap();
		}

		private IMap GenerateProofOfConceptMap()
		{
			var map = new Map();
			
			// Setup here

			// Just do this for now so it makes declaring in code more pretty
			var _ = TileType.Empty;
			var X = TileType.Floor;

			// Spiral to me, spiral through me
			map.MapData = new TileType[,]
			{
				{ X, X, X, X, X, X, X, X, X, _ },
				{ X, _, _, _, _, _, _, _, X, _ },
				{ X, _, X, X, X, X, X, _, X, _ },
				{ X, _, X, _, _, _, X, _, X, _ },
				{ X, _, X, _, X, _, X, _, X, _ },
				{ X, _, X, _, X, _, X, _, X, _ },
				{ X, _, X, _, X, X, X, _, X, _ },
				{ X, _, X, _, _, _, _, _, X, _ },
				{ X, _, X, X, X, X, X, X, X, _ },
				{ X, _, _, _, _, _, _, _, _, _ }
			};

			return map;
		}
	}
}
