using System.Collections.Generic;

public interface ICommando : ISpecialisedSoldier, IPrivate, ISoldier
{
    List<IMission> Missions { get; }
}