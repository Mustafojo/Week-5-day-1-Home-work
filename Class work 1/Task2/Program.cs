var post = new Post();
post.Text = "salom";
post.Likes = 10;
post.AddComment("Behtarin");
post.AddComment("fvb");

System.Console.WriteLine(post.GetInfo());
post.Cout();