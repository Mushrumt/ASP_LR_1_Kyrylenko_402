﻿public class Company
    {
        public string Name { get; set; }
        public string Head { get; set; }
        public string Location { get; set; }
    


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                var company = new Company
                {
                    Name = "Lab 1 company",
                    Head = "Artem Kyrylenko",
                    Location = "Mykolaiv",
                };

                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync($"Company: {company.Name}\n" +
                                                  $"Founder & CEO: {company.Head}\nS" +
                                                  $"Founded: {company.Location}");
            });

            endpoints.MapGet("/task2", async context =>
            {
                var random = new Random();
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync($"Random number: {random.Next(0, 101)}");
            });
        });
    }
}
