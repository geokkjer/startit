import { BrowserRouter, NavLink, Outlet, Route, Routes } from "react-router-dom";

function PageNav() {
  return (
    <>
      <NavLink to="/">Home</NavLink>
      <NavLink to="pricing">Pricing</NavLink>
    </>
  )
function Categories(){
  return (
    <>
      <NavLink to="Men">Men</NavLink>
      <Outlet />
    </>
  );
}
}
function App() {
  return (
    <BrowserRouter basename="/shop">
      <PageNav />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="pricing" element={<Pricing />} />
        <Route path="categories" element={<Categories />}>
          <Route path="male" element={<Male />} />
          <Route path="female" element={<Female />} />
        </Route>
        <Route path="*" element={<PageNotFound />} />
      </Routes>

    </BrowserRouter>
  );
}

export default App;
