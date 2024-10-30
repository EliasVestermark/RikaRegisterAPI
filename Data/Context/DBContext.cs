using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class DBContext(DbContextOptions<DBContext> options) : IdentityDbContext<UserEntity>(options)
{
}
