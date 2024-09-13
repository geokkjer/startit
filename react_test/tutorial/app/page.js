
import { useState } from 'react';

function Header({ title }) {
  return <h1>{title ? title : 'Default Title'}</h1>;
}
export default function HomePage() {
  const names = ['Ada Lovlace', 'Grace Hopper', 'Margaret Hamilton'];

  const [likes, setLikes] = React.useState(0);

  function handleClick() {
    setLikes(likes + 1);
  }
  return (
    <div>
      <Header title="Develop. Preview. Ship." />
      <ul>
        {names.map((name) => (
          <li key={name}>{name}</li>
        ))}
      </ul>
      <button onClick={handleClick}>Likes ({likes})</button>
    </div>
  );
}

