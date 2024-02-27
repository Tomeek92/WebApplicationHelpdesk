using WebApplicationHelpdeskInfrastructure.Database.Extensions;
using WebApplicationHelpdeskInfrastructure.Database.Seeders;
using WebApplicationHelpdeskApi.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

var app = builder.Build();

var scope = app.Services.CreateScope();

var seeder = scope.ServiceProvider.GetRequiredService<ClientSeeder>();
await seeder.Seed();
var userClientSeeder = scope.ServiceProvider.GetRequiredService<UserClientSeeder>();
await userClientSeeder.Seed();
var ticketList = scope.ServiceProvider.GetRequiredService<TicketListSeeder>();
await ticketList.Seed();
var ticketPriority = scope.ServiceProvider.GetRequiredService<TicketPrioritySeeder>();
await ticketPriority.Seed();   
var ticketStatus = scope.ServiceProvider.GetRequiredService<TicketStatusSeeder>();
await ticketStatus.Seed(); 
var userHelpdesk = scope.ServiceProvider.GetRequiredService<UserHelpdeskSeeder>();
await userHelpdesk.Seed();
var registerUserForClient = scope.ServiceProvider.GetRequiredService<RegisterForClientSeeder>();
await registerUserForClient.Seed();
var registerUserForHelpdesk = scope.ServiceProvider.GetRequiredService<RegisterForHelpdeskSeeder>();
await registerUserForHelpdesk.Seed();   

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
