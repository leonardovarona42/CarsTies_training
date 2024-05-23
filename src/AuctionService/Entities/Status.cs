namespace AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

public enum Status
{
    Live,
    Finished,
    ReserveNotMet
}
